namespace MqttExample
{
	partial class Main
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tb_log = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.smi_Clear = new System.Windows.Forms.ToolStripMenuItem();
			this.tb_Server = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_SubTopic = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_PubTopic = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_Message = new System.Windows.Forms.TextBox();
			this.cob_PubQos = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.bt_Publish = new System.Windows.Forms.Button();
			this.bt_Connect = new System.Windows.Forms.Button();
			this.bt_Subscribe = new System.Windows.Forms.Button();
			this.bt_UnSubscribe = new System.Windows.Forms.Button();
			this.bt_UnConnect = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_UserName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_ClientId = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cob_CleanSession = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cob_SubQos = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cob_PubRetain = new System.Windows.Forms.ComboBox();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tb_log
			// 
			this.tb_log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_log.ContextMenuStrip = this.contextMenuStrip1;
			this.tb_log.Location = new System.Drawing.Point(0, 0);
			this.tb_log.Multiline = true;
			this.tb_log.Name = "tb_log";
			this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_log.Size = new System.Drawing.Size(837, 300);
			this.tb_log.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smi_Clear});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
			// 
			// smi_Clear
			// 
			this.smi_Clear.Name = "smi_Clear";
			this.smi_Clear.Size = new System.Drawing.Size(116, 22);
			this.smi_Clear.Text = "清空(&C)";
			this.smi_Clear.Click += new System.EventHandler(this.smi_Clear_Click);
			// 
			// tb_Server
			// 
			this.tb_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_Server.Location = new System.Drawing.Point(84, 312);
			this.tb_Server.Name = "tb_Server";
			this.tb_Server.Size = new System.Drawing.Size(154, 21);
			this.tb_Server.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 316);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Server:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 371);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "Sub Topics:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_SubTopic
			// 
			this.tb_SubTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_SubTopic.Location = new System.Drawing.Point(84, 368);
			this.tb_SubTopic.Multiline = true;
			this.tb_SubTopic.Name = "tb_SubTopic";
			this.tb_SubTopic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_SubTopic.Size = new System.Drawing.Size(452, 57);
			this.tb_SubTopic.TabIndex = 3;
			this.tb_SubTopic.Text = "$SYS/brokers/+/sysmon/#;$SYS/brokers/+/alarms/#;$SYS/brokers/+/metrics/messages/#" +
    ";$SYS/brokers/+/clients/#;toclient;toserver";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 435);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "Pub Topics:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_PubTopic
			// 
			this.tb_PubTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_PubTopic.Location = new System.Drawing.Point(84, 431);
			this.tb_PubTopic.Name = "tb_PubTopic";
			this.tb_PubTopic.Size = new System.Drawing.Size(452, 21);
			this.tb_PubTopic.TabIndex = 5;
			this.tb_PubTopic.Text = "toserver";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 462);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "Message:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_Message
			// 
			this.tb_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Message.Location = new System.Drawing.Point(84, 458);
			this.tb_Message.Name = "tb_Message";
			this.tb_Message.Size = new System.Drawing.Size(452, 21);
			this.tb_Message.TabIndex = 7;
			this.tb_Message.Text = "Hello World";
			// 
			// cob_PubQos
			// 
			this.cob_PubQos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cob_PubQos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_PubQos.FormattingEnabled = true;
			this.cob_PubQos.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
			this.cob_PubQos.Location = new System.Drawing.Point(598, 431);
			this.cob_PubQos.Name = "cob_PubQos";
			this.cob_PubQos.Size = new System.Drawing.Size(55, 20);
			this.cob_PubQos.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(542, 435);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 10;
			this.label5.Text = "Pub Qos:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// bt_Publish
			// 
			this.bt_Publish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Publish.Location = new System.Drawing.Point(670, 457);
			this.bt_Publish.Name = "bt_Publish";
			this.bt_Publish.Size = new System.Drawing.Size(75, 23);
			this.bt_Publish.TabIndex = 11;
			this.bt_Publish.Text = "Publish";
			this.bt_Publish.UseVisualStyleBackColor = true;
			this.bt_Publish.Click += new System.EventHandler(this.bt_Publish_Click);
			// 
			// bt_Connect
			// 
			this.bt_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Connect.Location = new System.Drawing.Point(670, 311);
			this.bt_Connect.Name = "bt_Connect";
			this.bt_Connect.Size = new System.Drawing.Size(75, 23);
			this.bt_Connect.TabIndex = 12;
			this.bt_Connect.Text = "Connect";
			this.bt_Connect.UseVisualStyleBackColor = true;
			this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
			// 
			// bt_Subscribe
			// 
			this.bt_Subscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Subscribe.Location = new System.Drawing.Point(670, 403);
			this.bt_Subscribe.Name = "bt_Subscribe";
			this.bt_Subscribe.Size = new System.Drawing.Size(75, 23);
			this.bt_Subscribe.TabIndex = 13;
			this.bt_Subscribe.Text = "Subscribe";
			this.bt_Subscribe.UseVisualStyleBackColor = true;
			this.bt_Subscribe.Click += new System.EventHandler(this.bt_Subscribe_Click);
			// 
			// bt_UnSubscribe
			// 
			this.bt_UnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_UnSubscribe.Location = new System.Drawing.Point(753, 403);
			this.bt_UnSubscribe.Name = "bt_UnSubscribe";
			this.bt_UnSubscribe.Size = new System.Drawing.Size(75, 23);
			this.bt_UnSubscribe.TabIndex = 14;
			this.bt_UnSubscribe.Text = "Unsubscribe";
			this.bt_UnSubscribe.UseVisualStyleBackColor = true;
			this.bt_UnSubscribe.Click += new System.EventHandler(this.bt_UnSubscribe_Click);
			// 
			// bt_UnConnect
			// 
			this.bt_UnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_UnConnect.Location = new System.Drawing.Point(753, 311);
			this.bt_UnConnect.Name = "bt_UnConnect";
			this.bt_UnConnect.Size = new System.Drawing.Size(75, 23);
			this.bt_UnConnect.TabIndex = 15;
			this.bt_UnConnect.Text = "Disconnect";
			this.bt_UnConnect.UseVisualStyleBackColor = true;
			this.bt_UnConnect.Click += new System.EventHandler(this.bt_UnConnect_Click);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(271, 316);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 12);
			this.label6.TabIndex = 17;
			this.label6.Text = "User Name:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_UserName
			// 
			this.tb_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_UserName.Location = new System.Drawing.Point(342, 312);
			this.tb_UserName.Name = "tb_UserName";
			this.tb_UserName.Size = new System.Drawing.Size(111, 21);
			this.tb_UserName.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(477, 316);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 12);
			this.label7.TabIndex = 19;
			this.label7.Text = "Password:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_Password
			// 
			this.tb_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_Password.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.tb_Password.Location = new System.Drawing.Point(542, 312);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.PasswordChar = '✪';
			this.tb_Password.Size = new System.Drawing.Size(111, 21);
			this.tb_Password.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 345);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 12);
			this.label8.TabIndex = 21;
			this.label8.Text = "Client Id:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_ClientId
			// 
			this.tb_ClientId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_ClientId.Location = new System.Drawing.Point(84, 341);
			this.tb_ClientId.Name = "tb_ClientId";
			this.tb_ClientId.Size = new System.Drawing.Size(154, 21);
			this.tb_ClientId.TabIndex = 20;
			this.tb_ClientId.Text = "client1";
			this.tb_ClientId.TextChanged += new System.EventHandler(this.tb_ClientId_TextChanged);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(247, 345);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 12);
			this.label9.TabIndex = 23;
			this.label9.Text = "Clean Session:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cob_CleanSession
			// 
			this.cob_CleanSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cob_CleanSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_CleanSession.FormattingEnabled = true;
			this.cob_CleanSession.Items.AddRange(new object[] {
            "False",
            "True"});
			this.cob_CleanSession.Location = new System.Drawing.Point(342, 341);
			this.cob_CleanSession.Name = "cob_CleanSession";
			this.cob_CleanSession.Size = new System.Drawing.Size(111, 20);
			this.cob_CleanSession.TabIndex = 22;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(542, 408);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 12);
			this.label10.TabIndex = 25;
			this.label10.Text = "Sub Qos:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cob_SubQos
			// 
			this.cob_SubQos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cob_SubQos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_SubQos.FormattingEnabled = true;
			this.cob_SubQos.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
			this.cob_SubQos.Location = new System.Drawing.Point(598, 404);
			this.cob_SubQos.Name = "cob_SubQos";
			this.cob_SubQos.Size = new System.Drawing.Size(55, 20);
			this.cob_SubQos.TabIndex = 24;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(548, 462);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 12);
			this.label11.TabIndex = 27;
			this.label11.Text = "Retain:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cob_PubRetain
			// 
			this.cob_PubRetain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cob_PubRetain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_PubRetain.FormattingEnabled = true;
			this.cob_PubRetain.Items.AddRange(new object[] {
            "False",
            "True"});
			this.cob_PubRetain.Location = new System.Drawing.Point(598, 458);
			this.cob_PubRetain.Name = "cob_PubRetain";
			this.cob_PubRetain.Size = new System.Drawing.Size(55, 20);
			this.cob_PubRetain.TabIndex = 26;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 487);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cob_PubRetain);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cob_SubQos);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.cob_CleanSession);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tb_ClientId);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tb_Password);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tb_UserName);
			this.Controls.Add(this.bt_UnConnect);
			this.Controls.Add(this.bt_UnSubscribe);
			this.Controls.Add(this.bt_Subscribe);
			this.Controls.Add(this.bt_Connect);
			this.Controls.Add(this.bt_Publish);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cob_PubQos);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tb_Message);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_PubTopic);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_SubTopic);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_Server);
			this.Controls.Add(this.tb_log);
			this.MinimumSize = new System.Drawing.Size(853, 526);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mqtt client example";
			this.Load += new System.EventHandler(this.Main_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_log;
		private System.Windows.Forms.TextBox tb_Server;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_SubTopic;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_PubTopic;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_Message;
		private System.Windows.Forms.ComboBox cob_PubQos;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button bt_Publish;
		private System.Windows.Forms.Button bt_Connect;
		private System.Windows.Forms.Button bt_Subscribe;
		private System.Windows.Forms.Button bt_UnSubscribe;
		private System.Windows.Forms.Button bt_UnConnect;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_UserName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_ClientId;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cob_CleanSession;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cob_SubQos;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cob_PubRetain;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem smi_Clear;
	}
}

