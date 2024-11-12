namespace LocalRabbitMQ_FormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnConnect = new Button();
            txtConnectionString = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox4 = new GroupBox();
            cboxExchangeType = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            btnDeclareExchange = new Button();
            txtExchangeName = new TextBox();
            groupBox5 = new GroupBox();
            label5 = new Label();
            btnBindQueue = new Button();
            txtRoutingKey1 = new TextBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            btnDeclareQue = new Button();
            txtQueName = new TextBox();
            groupBox6 = new GroupBox();
            numCounter = new NumericUpDown();
            btnPublish = new Button();
            checkUseCounter = new CheckBox();
            txtRepeatCount = new TextBox();
            txtMessage = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtPublishRoutingKey = new TextBox();
            cboxPublishExchangeType = new ComboBox();
            txtPublishExchange = new TextBox();
            groupBox7 = new GroupBox();
            txtLog = new RichTextBox();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCounter).BeginInit();
            groupBox7.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConnect);
            groupBox1.Controls.Add(txtConnectionString);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(609, 51);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(479, 19);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(119, 23);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Location = new Point(112, 16);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(361, 23);
            txtConnectionString.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Connection String";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(12, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(609, 142);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Queue / Exchange Declare & Bind";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboxExchangeType);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(btnDeclareExchange);
            groupBox4.Controls.Add(txtExchangeName);
            groupBox4.Location = new Point(208, 22);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(187, 110);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Declare Exchange";
            // 
            // cboxExchangeType
            // 
            cboxExchangeType.FormattingEnabled = true;
            cboxExchangeType.Location = new Point(94, 45);
            cboxExchangeType.Name = "cboxExchangeType";
            cboxExchangeType.Size = new Size(87, 23);
            cboxExchangeType.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 49);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // btnDeclareExchange
            // 
            btnDeclareExchange.Location = new Point(94, 74);
            btnDeclareExchange.Name = "btnDeclareExchange";
            btnDeclareExchange.Size = new Size(87, 23);
            btnDeclareExchange.TabIndex = 2;
            btnDeclareExchange.Text = "Declare";
            btnDeclareExchange.UseVisualStyleBackColor = true;
            btnDeclareExchange.Click += btnDeclareExchange_Click;
            // 
            // txtExchangeName
            // 
            txtExchangeName.Location = new Point(94, 16);
            txtExchangeName.Name = "txtExchangeName";
            txtExchangeName.Size = new Size(87, 23);
            txtExchangeName.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(btnBindQueue);
            groupBox5.Controls.Add(txtRoutingKey1);
            groupBox5.Location = new Point(410, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(187, 110);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Bind Queue & Exchange";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 0;
            label5.Text = "Routing Key";
            // 
            // btnBindQueue
            // 
            btnBindQueue.Location = new Point(89, 45);
            btnBindQueue.Name = "btnBindQueue";
            btnBindQueue.Size = new Size(87, 23);
            btnBindQueue.TabIndex = 2;
            btnBindQueue.Text = "Bind Queue";
            btnBindQueue.UseVisualStyleBackColor = true;
            btnBindQueue.Click += btnBindQueue_Click;
            // 
            // txtRoutingKey1
            // 
            txtRoutingKey1.Location = new Point(89, 16);
            txtRoutingKey1.Name = "txtRoutingKey1";
            txtRoutingKey1.Size = new Size(87, 23);
            txtRoutingKey1.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(btnDeclareQue);
            groupBox3.Controls.Add(txtQueName);
            groupBox3.Location = new Point(6, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(187, 110);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Declare Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 0;
            label2.Text = "Queue Name";
            // 
            // btnDeclareQue
            // 
            btnDeclareQue.Location = new Point(89, 74);
            btnDeclareQue.Name = "btnDeclareQue";
            btnDeclareQue.Size = new Size(87, 23);
            btnDeclareQue.TabIndex = 2;
            btnDeclareQue.Text = "Declare";
            btnDeclareQue.UseVisualStyleBackColor = true;
            btnDeclareQue.Click += btnDeclareQue_Click;
            // 
            // txtQueName
            // 
            txtQueName.Location = new Point(89, 16);
            txtQueName.Name = "txtQueName";
            txtQueName.Size = new Size(87, 23);
            txtQueName.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(numCounter);
            groupBox6.Controls.Add(btnPublish);
            groupBox6.Controls.Add(checkUseCounter);
            groupBox6.Controls.Add(txtRepeatCount);
            groupBox6.Controls.Add(txtMessage);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(label6);
            groupBox6.Controls.Add(txtPublishRoutingKey);
            groupBox6.Controls.Add(cboxPublishExchangeType);
            groupBox6.Controls.Add(txtPublishExchange);
            groupBox6.Location = new Point(15, 233);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(324, 293);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Create Publish";
            // 
            // numCounter
            // 
            numCounter.Location = new Point(126, 232);
            numCounter.Name = "numCounter";
            numCounter.Size = new Size(94, 23);
            numCounter.TabIndex = 7;
            // 
            // btnPublish
            // 
            btnPublish.Location = new Point(126, 261);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(188, 23);
            btnPublish.TabIndex = 6;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            btnPublish.Click += btnPublish_Click;
            // 
            // checkUseCounter
            // 
            checkUseCounter.AutoSize = true;
            checkUseCounter.Location = new Point(226, 236);
            checkUseCounter.Name = "checkUseCounter";
            checkUseCounter.Size = new Size(88, 19);
            checkUseCounter.TabIndex = 5;
            checkUseCounter.Text = "UseCounter";
            checkUseCounter.UseVisualStyleBackColor = true;
            // 
            // txtRepeatCount
            // 
            txtRepeatCount.Location = new Point(6, 214);
            txtRepeatCount.Name = "txtRepeatCount";
            txtRepeatCount.Size = new Size(87, 23);
            txtRepeatCount.TabIndex = 4;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(126, 84);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(188, 142);
            txtMessage.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(67, 84);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 0;
            label8.Text = "Message";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 240);
            label9.Name = "label9";
            label9.Size = new Size(43, 15);
            label9.TabIndex = 0;
            label9.Text = "Repeat";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 53);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 0;
            label7.Text = "Routing Key";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(122, 15);
            label6.TabIndex = 0;
            label6.Text = "Exchange Name/Type";
            // 
            // txtPublishRoutingKey
            // 
            txtPublishRoutingKey.Location = new Point(134, 45);
            txtPublishRoutingKey.Name = "txtPublishRoutingKey";
            txtPublishRoutingKey.Size = new Size(180, 23);
            txtPublishRoutingKey.TabIndex = 1;
            // 
            // cboxPublishExchangeType
            // 
            cboxPublishExchangeType.FormattingEnabled = true;
            cboxPublishExchangeType.Location = new Point(227, 16);
            cboxPublishExchangeType.Name = "cboxPublishExchangeType";
            cboxPublishExchangeType.Size = new Size(87, 23);
            cboxPublishExchangeType.TabIndex = 2;
            // 
            // txtPublishExchange
            // 
            txtPublishExchange.Location = new Point(134, 16);
            txtPublishExchange.Name = "txtPublishExchange";
            txtPublishExchange.Size = new Size(87, 23);
            txtPublishExchange.TabIndex = 1;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtLog);
            groupBox7.Location = new Point(345, 233);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(276, 293);
            groupBox7.TabIndex = 5;
            groupBox7.TabStop = false;
            groupBox7.Text = "Log";
            // 
            // txtLog
            // 
            txtLog.BackColor = Color.Silver;
            txtLog.Location = new Point(6, 21);
            txtLog.Name = "txtLog";
            txtLog.Size = new Size(264, 263);
            txtLog.TabIndex = 5;
            txtLog.Text = "";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 547);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(632, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(159, 17);
            lblStatus.Text = "Connection :  NotConnected";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 569);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCounter).EndInit();
            groupBox7.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnConnect;
        private TextBox txtConnectionString;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnDeclareQue;
        private TextBox txtQueName;
        private Label label2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox cboxExchangeType;
        private Label label4;
        private Label label3;
        private Button btnDeclareExchange;
        private TextBox txtExchangeName;
        private GroupBox groupBox5;
        private Label label5;
        private Button btnBindQueue;
        private TextBox txtRoutingKey1;
        private GroupBox groupBox6;
        private Button btnPublish;
        private CheckBox checkUseCounter;
        private TextBox txtRepeatCount;
        private TextBox txtMessage;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label6;
        private TextBox txtPublishRoutingKey;
        private ComboBox cboxPublishExchangeType;
        private TextBox txtPublishExchange;
        private GroupBox groupBox7;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private RichTextBox txtLog;
        private NumericUpDown numCounter;
    }
}
