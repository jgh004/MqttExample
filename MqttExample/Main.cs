using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.ManagedClient;
using MQTTnet.Protocol;
using MQTTnet.Serializer;

namespace MqttExample
{
	public partial class Main : Form
	{
		private SynchronizationContext sync;
		private IManagedMqttClient mClient;
		private IMqttClient client;

		/// <summary>
		/// reconnect flag
		/// </summary>
		private volatile bool enableReconnect;

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load( object sender, EventArgs e )
		{
			sync = SynchronizationContext.Current;
			tb_ClientId_TextChanged( null, null );
			cob_CleanSession.SelectedIndex = 1;
			cob_PubQos.SelectedIndex = 1;
			cob_SubQos.SelectedIndex = 2;
			cob_PubRetain.SelectedIndex = 0;
			cob_WillQos.SelectedIndex = 2;
			cob_WillRetain.SelectedIndex = 1;
		}

		private void tb_ClientId_TextChanged( object sender, EventArgs e )
		{
			Text = tb_ClientId.Text.Trim();
		}

		private void smi_Clear_Click( object sender, EventArgs e )
		{
			tb_log.Clear();
		}

		private void bt_Connect_Click( object sender, EventArgs e )
		{
			enableReconnect = true;
			ConnectAsync().ConfigureAwait( false );
		}

		private void bt_UnConnect_Click( object sender, EventArgs e )
		{
			enableReconnect = false;
			DisconnectAsync().ConfigureAwait( false );
		}

		private void bt_Subscribe_Click( object sender, EventArgs e )
		{
			SubscribeAsync().ConfigureAwait( false );
		}

		private void bt_UnSubscribe_Click( object sender, EventArgs e )
		{
			UnSubscribeAsync().ConfigureAwait( false );
		}

		private void bt_Publish_Click( object sender, EventArgs e )
		{
			PublishAsync().ConfigureAwait( false );
		}

		private void Client_Connected( object sender, MqttClientConnectedEventArgs e )
		{
			ShowLog( $"Connect OK,exists server's session:{e.IsSessionPresent}" );
		}

		private void Client_Disconnected( object sender, MqttClientDisconnectedEventArgs e )
		{
			ShowLog( $"Disconnected, from status:{e.ClientWasConnected}" +
				$"{(e.Exception == null ? "" : ", error:" + e.Exception.Message)}" );

			if ( enableReconnect )
			{
				Task.Delay( 5000 ).ContinueWith( async f =>
				{
					await ConnectAsync();
				} ).ConfigureAwait( false );
			}
		}

		private void Client_ApplicationMessageReceived( object sender, MqttApplicationMessageReceivedEventArgs e )
		{
			ShowLog( $"Received message, from client:{e.ClientId}" +
				$", from topic:{e.ApplicationMessage.Topic}" +
				$", qos:{(int)e.ApplicationMessage.QualityOfServiceLevel}" +
				$", retain:{e.ApplicationMessage.Retain}" +
				$", payload:{Encoding.UTF8.GetString( e.ApplicationMessage.Payload )}" );
		}


		private void ShowLog( string log )
		{
			sync.Post( f =>
			{
				if ( tb_log.Lines.Length > 500 )
				{
					tb_log.Text = "";
				}

				tb_log.Text += log + "\r\n";
				tb_log.SelectionStart = tb_log.Text.Length;
				tb_log.ScrollToCaret();
			}, log );
		}

		private async Task ConnectAsync()
		{
			try
			{
				if ( client == null )
				{
					client = new MqttFactory().CreateMqttClient();
					client.ApplicationMessageReceived += Client_ApplicationMessageReceived;
					client.Connected += Client_Connected;
					client.Disconnected += Client_Disconnected;
				}

				if ( !client.IsConnected )
				{
					var option = new MqttClientOptionsBuilder()
						.WithCleanSession( Convert.ToBoolean( cob_CleanSession.SelectedItem ) )
						.WithClientId( tb_ClientId.Text.Trim() )
						.WithCommunicationTimeout( TimeSpan.FromSeconds( 5 ) )
						.WithCredentials( tb_UserName.Text.Trim(), tb_Password.Text.Trim() )
						.WithKeepAlivePeriod( TimeSpan.FromSeconds( 5 ) )
						.WithProtocolVersion( MqttProtocolVersion.V311 )
						.WithTcpServer( tb_Server.Text.Trim() );

					if ( !string.IsNullOrWhiteSpace( tb_WillTopic.Text ) )
					{
						var msg = new MqttApplicationMessageBuilder()
							.WithTopic( tb_WillTopic.Text.Trim() )
							.WithQualityOfServiceLevel( (MqttQualityOfServiceLevel)Convert.ToInt32( cob_WillQos.SelectedItem ) )
							.WithRetainFlag( Convert.ToBoolean( cob_WillRetain.SelectedItem ) )
							.WithPayload( tb_WillMessage.Text.Trim() )
							.Build();
						option = option.WithWillMessage( msg );
					}

					await client.ConnectAsync( option.Build() );
				}
			}
			catch ( Exception ex )
			{
			}
		}
		
		private async Task DisconnectAsync()
		{
			try
			{
				if ( mClient != null )
				{
					await mClient.StopAsync();
					mClient = null;
				}

				if ( client != null )
				{
					await client.DisconnectAsync();
					client = null;
				}
			}
			catch ( Exception ex )
			{
			}
		}
		
		private async Task SubscribeAsync()
		{
			try
			{
				var tps = tb_SubTopic.Text.Trim().Split( new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries );

				if ( tps != null )
				{
					var topics = from t in tps
								 select new TopicFilter( t, (MqttQualityOfServiceLevel)Convert.ToInt32( cob_SubQos.SelectedItem ) );

					foreach ( var t in topics.ToList() )
					{
						await client.SubscribeAsync( t );
					}

					ShowLog( "Subscribe OK" );
				}
			}
			catch ( Exception ex )
			{
				ShowLog( $"Subscribe error:{ex.Message}" );
			}
		}
		
		private async Task UnSubscribeAsync()
		{
			try
			{
				var tps = tb_SubTopic.Text.Trim().Split( new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries );

				if ( tps != null )
				{
					foreach ( var t in tps.ToList() )
					{
						await client.UnsubscribeAsync( t );
					}

					ShowLog( "Unsubscribe OK" );
				}
			}
			catch ( Exception ex )
			{
				ShowLog( $"Unsubscribe error:{ex.Message}" );
			}
		}
		
		private async Task PublishAsync()
		{
			try
			{
				var tps = tb_PubTopic.Text.Trim().Split( new char[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries );

				if ( tps != null )
				{
					var msgs = from t in tps
							   select new MqttApplicationMessageBuilder()
							   .WithPayload( tb_Message.Text.Trim() )
							   .WithQualityOfServiceLevel( (MqttQualityOfServiceLevel)Convert.ToInt32( cob_PubQos.SelectedItem ) )
							   .WithRetainFlag( Convert.ToBoolean( cob_PubRetain.SelectedItem ) )
							   .WithTopic( t )
							   .Build();

					await client.PublishAsync( msgs );
					ShowLog( "Publish OK" );
				}
			}
			catch ( Exception ex )
			{
				ShowLog( $"Publish error:{ex.Message}" );
			}
		}
	}
}
