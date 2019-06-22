namespace ClientUI
{
    partial class ClientUI
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
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.sendMessageBtn = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.connectStatusTextBox = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.portLbl = new System.Windows.Forms.Label();
            this.IPlbl = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.msgSendRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // chatList
            // 
            this.chatList.FormattingEnabled = true;
            this.chatList.Location = new System.Drawing.Point(10, 62);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(432, 160);
            this.chatList.TabIndex = 28;
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.BackColor = System.Drawing.SystemColors.Control;
            this.disconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.disconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.disconnectBtn.ForeColor = System.Drawing.Color.Black;
            this.disconnectBtn.Location = new System.Drawing.Point(370, 8);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(72, 48);
            this.disconnectBtn.TabIndex = 27;
            this.disconnectBtn.Text = "Disconnet From Server";
            this.disconnectBtn.UseVisualStyleBackColor = false;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // sendMessageBtn
            // 
            this.sendMessageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendMessageBtn.Location = new System.Drawing.Point(124, 268);
            this.sendMessageBtn.Name = "sendMessageBtn";
            this.sendMessageBtn.Size = new System.Drawing.Size(200, 34);
            this.sendMessageBtn.TabIndex = 26;
            this.sendMessageBtn.Text = "Send Message";
            this.sendMessageBtn.Click += new System.EventHandler(this.sendMessageBtn_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.Location = new System.Drawing.Point(2, 326);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(104, 16);
            this.statusLbl.TabIndex = 25;
            this.statusLbl.Text = "Connection Status";
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(338, 320);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(104, 24);
            this.closeBtn.TabIndex = 24;
            this.closeBtn.Text = "Close";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // connectStatusTextBox
            // 
            this.connectStatusTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.connectStatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectStatusTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.connectStatusTextBox.Location = new System.Drawing.Point(114, 326);
            this.connectStatusTextBox.Name = "connectStatusTextBox";
            this.connectStatusTextBox.ReadOnly = true;
            this.connectStatusTextBox.Size = new System.Drawing.Size(240, 13);
            this.connectStatusTextBox.TabIndex = 23;
            this.connectStatusTextBox.Text = "Not Connected";
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.SystemColors.Control;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectBtn.ForeColor = System.Drawing.Color.Black;
            this.connectBtn.Location = new System.Drawing.Point(292, 8);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(72, 48);
            this.connectBtn.TabIndex = 22;
            this.connectBtn.Text = "Connect To Server";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(114, 31);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(48, 20);
            this.portTextBox.TabIndex = 21;
            this.portTextBox.Text = "1234";
            // 
            // portLbl
            // 
            this.portLbl.Location = new System.Drawing.Point(10, 33);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(64, 16);
            this.portLbl.TabIndex = 20;
            this.portLbl.Text = "Port";
            // 
            // IPlbl
            // 
            this.IPlbl.Location = new System.Drawing.Point(10, 8);
            this.IPlbl.Name = "IPlbl";
            this.IPlbl.Size = new System.Drawing.Size(96, 16);
            this.IPlbl.TabIndex = 19;
            this.IPlbl.Text = "Server IP";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(114, 8);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(152, 20);
            this.ipTextBox.TabIndex = 18;
            // 
            // msgSendRichTextBox
            // 
            this.msgSendRichTextBox.Location = new System.Drawing.Point(10, 228);
            this.msgSendRichTextBox.Name = "msgSendRichTextBox";
            this.msgSendRichTextBox.Size = new System.Drawing.Size(432, 34);
            this.msgSendRichTextBox.TabIndex = 17;
            this.msgSendRichTextBox.Text = "";
            // 
            // ClientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 353);
            this.Controls.Add(this.chatList);
            this.Controls.Add(this.disconnectBtn);
            this.Controls.Add(this.sendMessageBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.connectStatusTextBox);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.IPlbl);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.msgSendRichTextBox);
            this.Name = "ClientUI";
            this.Text = "ClientUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox chatList;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button sendMessageBtn;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox connectStatusTextBox;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label portLbl;
        private System.Windows.Forms.Label IPlbl;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.RichTextBox msgSendRichTextBox;
    }
}