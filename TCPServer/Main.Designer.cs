
namespace TCPServer
{
    partial class Main
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.lblServer = new MetroFramework.Controls.MetroLabel();
            this.txtIP = new MetroFramework.Controls.MetroTextBox();
            this.lstClientIP = new System.Windows.Forms.ListBox();
            this.lblClientIP = new MetroFramework.Controls.MetroLabel();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.txtInfo = new MetroFramework.Controls.MetroTextBox();
            this.txtPlain = new MetroFramework.Controls.MetroTextBox();
            this.txtCipher = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AccessibleName = "lblPlain";
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 542);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Cipher Text";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleName = "lblPlain";
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 421);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Plain Text";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(309, 666);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(24, 56);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(47, 19);
            this.lblServer.TabIndex = 7;
            this.lblServer.Text = "Server";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(76, 56);
            this.txtIP.Multiline = true;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(389, 23);
            this.txtIP.TabIndex = 11;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // lstClientIP
            // 
            this.lstClientIP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstClientIP.FormattingEnabled = true;
            this.lstClientIP.Location = new System.Drawing.Point(484, 106);
            this.lstClientIP.Name = "lstClientIP";
            this.lstClientIP.Size = new System.Drawing.Size(164, 550);
            this.lstClientIP.TabIndex = 12;
            // 
            // lblClientIP
            // 
            this.lblClientIP.AutoSize = true;
            this.lblClientIP.Location = new System.Drawing.Point(484, 84);
            this.lblClientIP.Name = "lblClientIP";
            this.lblClientIP.Size = new System.Drawing.Size(53, 19);
            this.lblClientIP.TabIndex = 13;
            this.lblClientIP.Text = "ClientIP";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(390, 666);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(23, 106);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(442, 312);
            this.txtInfo.TabIndex = 16;
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(23, 443);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(442, 96);
            this.txtPlain.TabIndex = 17;
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(23, 564);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.ReadOnly = true;
            this.txtCipher.Size = new System.Drawing.Size(442, 96);
            this.txtCipher.TabIndex = 18;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 707);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblClientIP);
            this.Controls.Add(this.lstClientIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel2);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSend;
        private MetroFramework.Controls.MetroLabel lblServer;
        private MetroFramework.Controls.MetroTextBox txtIP;
        private System.Windows.Forms.ListBox lstClientIP;
        private MetroFramework.Controls.MetroLabel lblClientIP;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroTextBox txtInfo;
        private MetroFramework.Controls.MetroTextBox txtPlain;
        private MetroFramework.Controls.MetroTextBox txtCipher;
    }
}