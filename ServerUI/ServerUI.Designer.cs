namespace ServerUI
{
    partial class ServerUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chatList = new System.Windows.Forms.ListBox();
            this.textBoxMsg = new System.Windows.Forms.TextBox();
            this.statusMsgLbl = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.sendMsgBtn = new System.Windows.Forms.Button();
            this.richTextBoxSendMsg = new System.Windows.Forms.RichTextBox();
            this.stopListenBtn = new System.Windows.Forms.Button();
            this.startListenBtn = new System.Windows.Forms.Button();
            this.IPlabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chatList
            // 
            this.chatList.FormattingEnabled = true;
            this.chatList.Location = new System.Drawing.Point(14, 62);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(400, 134);
            this.chatList.TabIndex = 28;
            // 
            // textBoxMsg
            // 
            this.textBoxMsg.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMsg.ForeColor = System.Drawing.Color.Black;
            this.textBoxMsg.Location = new System.Drawing.Point(113, 318);
            this.textBoxMsg.Name = "textBoxMsg";
            this.textBoxMsg.ReadOnly = true;
            this.textBoxMsg.Size = new System.Drawing.Size(192, 13);
            this.textBoxMsg.TabIndex = 27;
            this.textBoxMsg.Text = "None";
            // 
            // statusMsgLbl
            // 
            this.statusMsgLbl.Location = new System.Drawing.Point(11, 318);
            this.statusMsgLbl.Name = "statusMsgLbl";
            this.statusMsgLbl.Size = new System.Drawing.Size(112, 16);
            this.statusMsgLbl.TabIndex = 26;
            this.statusMsgLbl.Text = "Status Message:";
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(90, 12);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.ReadOnly = true;
            this.IPTextBox.Size = new System.Drawing.Size(120, 20);
            this.IPTextBox.TabIndex = 25;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(326, 307);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(88, 24);
            this.closeBtn.TabIndex = 24;
            this.closeBtn.Text = "Close";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // sendMsgBtn
            // 
            this.sendMsgBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sendMsgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendMsgBtn.Location = new System.Drawing.Point(113, 242);
            this.sendMsgBtn.Name = "sendMsgBtn";
            this.sendMsgBtn.Size = new System.Drawing.Size(200, 34);
            this.sendMsgBtn.TabIndex = 23;
            this.sendMsgBtn.Text = "Send Message";
            this.sendMsgBtn.Click += new System.EventHandler(this.sendMsgBtn_Click);
            // 
            // richTextBoxSendMsg
            // 
            this.richTextBoxSendMsg.Location = new System.Drawing.Point(14, 202);
            this.richTextBoxSendMsg.Name = "richTextBoxSendMsg";
            this.richTextBoxSendMsg.Size = new System.Drawing.Size(400, 34);
            this.richTextBoxSendMsg.TabIndex = 22;
            this.richTextBoxSendMsg.Text = "";
            // 
            // stopListenBtn
            // 
            this.stopListenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.stopListenBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stopListenBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopListenBtn.ForeColor = System.Drawing.Color.Black;
            this.stopListenBtn.Location = new System.Drawing.Point(326, 12);
            this.stopListenBtn.Name = "stopListenBtn";
            this.stopListenBtn.Size = new System.Drawing.Size(88, 40);
            this.stopListenBtn.TabIndex = 21;
            this.stopListenBtn.Text = "Stop Listening";
            this.stopListenBtn.UseVisualStyleBackColor = false;
            this.stopListenBtn.Click += new System.EventHandler(this.stopListenBtn_Click);
            // 
            // startListenBtn
            // 
            this.startListenBtn.BackColor = System.Drawing.SystemColors.Control;
            this.startListenBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startListenBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startListenBtn.ForeColor = System.Drawing.Color.Black;
            this.startListenBtn.Location = new System.Drawing.Point(232, 12);
            this.startListenBtn.Name = "startListenBtn";
            this.startListenBtn.Size = new System.Drawing.Size(88, 40);
            this.startListenBtn.TabIndex = 20;
            this.startListenBtn.Text = "Start Listening";
            this.startListenBtn.UseVisualStyleBackColor = false;
            this.startListenBtn.Click += new System.EventHandler(this.startListenBtn_Click);
            // 
            // IPlabel
            // 
            this.IPlabel.Location = new System.Drawing.Point(18, 12);
            this.IPlabel.Name = "IPlabel";
            this.IPlabel.Size = new System.Drawing.Size(56, 16);
            this.IPlabel.TabIndex = 19;
            this.IPlabel.Text = "Server IP";
            // 
            // portLabel
            // 
            this.portLabel.Location = new System.Drawing.Point(18, 36);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(48, 16);
            this.portLabel.TabIndex = 18;
            this.portLabel.Text = "Port";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(90, 36);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(40, 20);
            this.portTextBox.TabIndex = 17;
            this.portTextBox.Text = "1234";
            // 
            // ServerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 345);
            this.Controls.Add(this.chatList);
            this.Controls.Add(this.textBoxMsg);
            this.Controls.Add(this.statusMsgLbl);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sendMsgBtn);
            this.Controls.Add(this.richTextBoxSendMsg);
            this.Controls.Add(this.stopListenBtn);
            this.Controls.Add(this.startListenBtn);
            this.Controls.Add(this.IPlabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.portTextBox);
            this.Name = "ServerUI";
            this.Text = "ServerUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chatList;
        private System.Windows.Forms.TextBox textBoxMsg;
        private System.Windows.Forms.Label statusMsgLbl;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button sendMsgBtn;
        private System.Windows.Forms.RichTextBox richTextBoxSendMsg;
        private System.Windows.Forms.Button stopListenBtn;
        private System.Windows.Forms.Button startListenBtn;
        private System.Windows.Forms.Label IPlabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox portTextBox;
    }
}