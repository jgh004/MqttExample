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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.smi_Clear = new System.Windows.Forms.ToolStripMenuItem();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.cob_PubRetain = new System.Windows.Forms.ComboBox();
			this.bt_Publish = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cob_PubQos = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_Message = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_PubTopic = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.cob_SubQos = new System.Windows.Forms.ComboBox();
			this.bt_UnSubscribe = new System.Windows.Forms.Button();
			this.bt_Subscribe = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_SubTopic = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.cob_WillRetain = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.tb_WillMessage = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cob_WillQos = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tb_WillTopic = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.cob_CleanSession = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_ClientId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_UserName = new System.Windows.Forms.TextBox();
			this.bt_UnConnect = new System.Windows.Forms.Button();
			this.bt_Connect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_Server = new System.Windows.Forms.TextBox();
			this.tb_log = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.nud_Port = new System.Windows.Forms.NumericUpDown();
			this.contextMenuStrip1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_Port)).BeginInit();
			this.SuspendLayout();
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
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.cob_PubRetain);
			this.panel3.Controls.Add(this.bt_Publish);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.cob_PubQos);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.tb_Message);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.tb_PubTopic);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 438);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(869, 69);
			this.panel3.TabIndex = 43;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(584, 41);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(47, 12);
			this.label11.TabIndex = 86;
			this.label11.Text = "Retain:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cob_PubRetain
			// 
			this.cob_PubRetain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cob_PubRetain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_PubRetain.FormattingEnabled = true;
			this.cob_PubRetain.Items.AddRange(new object[] {
            "False",
            "True"});
			this.cob_PubRetain.Location = new System.Drawing.Point(634, 37);
			this.cob_PubRetain.Name = "cob_PubRetain";
			this.cob_PubRetain.Size = new System.Drawing.Size(55, 20);
			this.cob_PubRetain.TabIndex = 95;
			// 
			// bt_Publish
			// 
			this.bt_Publish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Publish.Location = new System.Drawing.Point(701, 36);
			this.bt_Publish.Name = "bt_Publish";
			this.bt_Publish.Size = new System.Drawing.Size(75, 23);
			this.bt_Publish.TabIndex = 100;
			this.bt_Publish.Text = "Publish";
			this.bt_Publish.UseVisualStyleBackColor = true;
			this.bt_Publish.Click += new System.EventHandler(this.bt_Publish_Click);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(578, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 83;
			this.label5.Text = "Pub Qos:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cob_PubQos
			// 
			this.cob_PubQos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cob_PubQos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_PubQos.FormattingEnabled = true;
			this.cob_PubQos.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
			this.cob_PubQos.Location = new System.Drawing.Point(634, 10);
			this.cob_PubQos.Name = "cob_PubQos";
			this.cob_PubQos.Size = new System.Drawing.Size(55, 20);
			this.cob_PubQos.TabIndex = 85;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 81;
			this.label4.Text = "Message:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_Message
			// 
			this.tb_Message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Message.Location = new System.Drawing.Point(91, 37);
			this.tb_Message.Name = "tb_Message";
			this.tb_Message.Size = new System.Drawing.Size(445, 21);
			this.tb_Message.TabIndex = 90;
			this.tb_Message.Text = "Hello World";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 12);
			this.label3.TabIndex = 79;
			this.label3.Text = "Pub Topics:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_PubTopic
			// 
			this.tb_PubTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_PubTopic.Location = new System.Drawing.Point(91, 10);
			this.tb_PubTopic.Name = "tb_PubTopic";
			this.tb_PubTopic.Size = new System.Drawing.Size(445, 21);
			this.tb_PubTopic.TabIndex = 80;
			this.tb_PubTopic.Text = "toserver";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.cob_SubQos);
			this.panel2.Controls.Add(this.bt_UnSubscribe);
			this.panel2.Controls.Add(this.bt_Subscribe);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.tb_SubTopic);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 362);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(869, 76);
			this.panel2.TabIndex = 42;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(578, 50);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(53, 12);
			this.label10.TabIndex = 75;
			this.label10.Text = "Sub Qos:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cob_SubQos
			// 
			this.cob_SubQos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cob_SubQos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_SubQos.FormattingEnabled = true;
			this.cob_SubQos.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
			this.cob_SubQos.Location = new System.Drawing.Point(634, 46);
			this.cob_SubQos.Name = "cob_SubQos";
			this.cob_SubQos.Size = new System.Drawing.Size(55, 20);
			this.cob_SubQos.TabIndex = 65;
			// 
			// bt_UnSubscribe
			// 
			this.bt_UnSubscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_UnSubscribe.Location = new System.Drawing.Point(784, 45);
			this.bt_UnSubscribe.Name = "bt_UnSubscribe";
			this.bt_UnSubscribe.Size = new System.Drawing.Size(75, 23);
			this.bt_UnSubscribe.TabIndex = 75;
			this.bt_UnSubscribe.Text = "Unsubscribe";
			this.bt_UnSubscribe.UseVisualStyleBackColor = true;
			this.bt_UnSubscribe.Click += new System.EventHandler(this.bt_UnSubscribe_Click);
			// 
			// bt_Subscribe
			// 
			this.bt_Subscribe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Subscribe.Location = new System.Drawing.Point(701, 45);
			this.bt_Subscribe.Name = "bt_Subscribe";
			this.bt_Subscribe.Size = new System.Drawing.Size(75, 23);
			this.bt_Subscribe.TabIndex = 70;
			this.bt_Subscribe.Text = "Subscribe";
			this.bt_Subscribe.UseVisualStyleBackColor = true;
			this.bt_Subscribe.Click += new System.EventHandler(this.bt_Subscribe_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 12);
			this.label2.TabIndex = 64;
			this.label2.Text = "Sub Topics:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_SubTopic
			// 
			this.tb_SubTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_SubTopic.Location = new System.Drawing.Point(91, 11);
			this.tb_SubTopic.Multiline = true;
			this.tb_SubTopic.Name = "tb_SubTopic";
			this.tb_SubTopic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_SubTopic.Size = new System.Drawing.Size(445, 57);
			this.tb_SubTopic.TabIndex = 60;
			this.tb_SubTopic.Text = "$SYS/brokers/+/sysmon/#;$SYS/brokers/+/alarms/#;$SYS/brokers/+/metrics/messages/#" +
    ";$SYS/brokers/+/clients/#;will;toclient;toserver";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.nud_Port);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.cob_WillRetain);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.tb_WillMessage);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.cob_WillQos);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.tb_WillTopic);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.cob_CleanSession);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.tb_ClientId);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.tb_Password);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.tb_UserName);
			this.panel1.Controls.Add(this.bt_UnConnect);
			this.panel1.Controls.Add(this.bt_Connect);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tb_Server);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 242);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(869, 120);
			this.panel1.TabIndex = 41;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(584, 93);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(47, 12);
			this.label14.TabIndex = 70;
			this.label14.Text = "Retain:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cob_WillRetain
			// 
			this.cob_WillRetain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cob_WillRetain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_WillRetain.FormattingEnabled = true;
			this.cob_WillRetain.Items.AddRange(new object[] {
            "False",
            "True"});
			this.cob_WillRetain.Location = new System.Drawing.Point(634, 89);
			this.cob_WillRetain.Name = "cob_WillRetain";
			this.cob_WillRetain.Size = new System.Drawing.Size(55, 20);
			this.cob_WillRetain.TabIndex = 45;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(5, 92);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(83, 12);
			this.label15.TabIndex = 68;
			this.label15.Text = "Will Message:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_WillMessage
			// 
			this.tb_WillMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_WillMessage.Location = new System.Drawing.Point(91, 89);
			this.tb_WillMessage.Name = "tb_WillMessage";
			this.tb_WillMessage.Size = new System.Drawing.Size(445, 21);
			this.tb_WillMessage.TabIndex = 40;
			this.tb_WillMessage.Text = "bye";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(572, 66);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(59, 12);
			this.label12.TabIndex = 66;
			this.label12.Text = "Will Qos:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cob_WillQos
			// 
			this.cob_WillQos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cob_WillQos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_WillQos.FormattingEnabled = true;
			this.cob_WillQos.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
			this.cob_WillQos.Location = new System.Drawing.Point(634, 62);
			this.cob_WillQos.Name = "cob_WillQos";
			this.cob_WillQos.Size = new System.Drawing.Size(55, 20);
			this.cob_WillQos.TabIndex = 35;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(17, 66);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(71, 12);
			this.label13.TabIndex = 64;
			this.label13.Text = "Will Topic:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_WillTopic
			// 
			this.tb_WillTopic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_WillTopic.Location = new System.Drawing.Point(91, 62);
			this.tb_WillTopic.Name = "tb_WillTopic";
			this.tb_WillTopic.Size = new System.Drawing.Size(445, 21);
			this.tb_WillTopic.TabIndex = 30;
			this.tb_WillTopic.Text = "will";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(542, 39);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(89, 12);
			this.label9.TabIndex = 58;
			this.label9.Text = "Clean Session:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cob_CleanSession
			// 
			this.cob_CleanSession.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cob_CleanSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cob_CleanSession.FormattingEnabled = true;
			this.cob_CleanSession.Items.AddRange(new object[] {
            "False",
            "True"});
			this.cob_CleanSession.Location = new System.Drawing.Point(634, 35);
			this.cob_CleanSession.Name = "cob_CleanSession";
			this.cob_CleanSession.Size = new System.Drawing.Size(111, 20);
			this.cob_CleanSession.TabIndex = 25;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(23, 39);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 12);
			this.label8.TabIndex = 56;
			this.label8.Text = "Client Id:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_ClientId
			// 
			this.tb_ClientId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_ClientId.Location = new System.Drawing.Point(91, 35);
			this.tb_ClientId.Name = "tb_ClientId";
			this.tb_ClientId.Size = new System.Drawing.Size(445, 21);
			this.tb_ClientId.TabIndex = 20;
			this.tb_ClientId.Text = "client1";
			this.tb_ClientId.TextChanged += new System.EventHandler(this.tb_ClientId_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(572, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 12);
			this.label7.TabIndex = 54;
			this.label7.Text = "Password:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_Password
			// 
			this.tb_Password.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.tb_Password.Location = new System.Drawing.Point(634, 8);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.PasswordChar = '✪';
			this.tb_Password.Size = new System.Drawing.Size(116, 21);
			this.tb_Password.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(357, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 12);
			this.label6.TabIndex = 52;
			this.label6.Text = "User Name:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_UserName
			// 
			this.tb_UserName.Location = new System.Drawing.Point(425, 8);
			this.tb_UserName.Name = "tb_UserName";
			this.tb_UserName.Size = new System.Drawing.Size(111, 21);
			this.tb_UserName.TabIndex = 10;
			// 
			// bt_UnConnect
			// 
			this.bt_UnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_UnConnect.Location = new System.Drawing.Point(784, 88);
			this.bt_UnConnect.Name = "bt_UnConnect";
			this.bt_UnConnect.Size = new System.Drawing.Size(75, 23);
			this.bt_UnConnect.TabIndex = 55;
			this.bt_UnConnect.Text = "Disconnect";
			this.bt_UnConnect.UseVisualStyleBackColor = true;
			this.bt_UnConnect.Click += new System.EventHandler(this.bt_UnConnect_Click);
			// 
			// bt_Connect
			// 
			this.bt_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.bt_Connect.Location = new System.Drawing.Point(701, 88);
			this.bt_Connect.Name = "bt_Connect";
			this.bt_Connect.Size = new System.Drawing.Size(75, 23);
			this.bt_Connect.TabIndex = 50;
			this.bt_Connect.Text = "Connect";
			this.bt_Connect.UseVisualStyleBackColor = true;
			this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 37;
			this.label1.Text = "Server:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tb_Server
			// 
			this.tb_Server.Location = new System.Drawing.Point(91, 8);
			this.tb_Server.Name = "tb_Server";
			this.tb_Server.Size = new System.Drawing.Size(131, 21);
			this.tb_Server.TabIndex = 0;
			// 
			// tb_log
			// 
			this.tb_log.ContextMenuStrip = this.contextMenuStrip1;
			this.tb_log.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_log.Location = new System.Drawing.Point(0, 0);
			this.tb_log.Multiline = true;
			this.tb_log.Name = "tb_log";
			this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_log.Size = new System.Drawing.Size(869, 242);
			this.tb_log.TabIndex = 200;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(235, 12);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(35, 12);
			this.label16.TabIndex = 72;
			this.label16.Text = "Port:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nud_Port
			// 
			this.nud_Port.Location = new System.Drawing.Point(273, 9);
			this.nud_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.nud_Port.Name = "nud_Port";
			this.nud_Port.Size = new System.Drawing.Size(67, 21);
			this.nud_Port.TabIndex = 5;
			this.nud_Port.Value = new decimal(new int[] {
            1883,
            0,
            0,
            0});
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(869, 507);
			this.Controls.Add(this.tb_log);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.MinimumSize = new System.Drawing.Size(853, 526);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mqtt client example";
			this.Load += new System.EventHandler(this.Main_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nud_Port)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem smi_Clear;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cob_PubRetain;
		private System.Windows.Forms.Button bt_Publish;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cob_PubQos;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_Message;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_PubTopic;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cob_SubQos;
		private System.Windows.Forms.Button bt_UnSubscribe;
		private System.Windows.Forms.Button bt_Subscribe;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_SubTopic;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox cob_WillRetain;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox tb_WillMessage;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cob_WillQos;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tb_WillTopic;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cob_CleanSession;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_ClientId;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_UserName;
		private System.Windows.Forms.Button bt_UnConnect;
		private System.Windows.Forms.Button bt_Connect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_Server;
		private System.Windows.Forms.TextBox tb_log;
		private System.Windows.Forms.NumericUpDown nud_Port;
		private System.Windows.Forms.Label label16;
	}
}

