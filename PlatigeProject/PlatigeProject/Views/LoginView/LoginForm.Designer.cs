
namespace PlatigeProject.Views
{
    partial class LoginForm
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
            this.cbConnections = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblSyncInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbConnections
            // 
            this.cbConnections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConnections.FormattingEnabled = true;
            this.cbConnections.Location = new System.Drawing.Point(51, 94);
            this.cbConnections.Name = "cbConnections";
            this.cbConnections.Size = new System.Drawing.Size(316, 23);
            this.cbConnections.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose database";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(252, 120);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 15);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "add new connection";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(292, 201);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblSyncInfo
            // 
            this.lblSyncInfo.AutoSize = true;
            this.lblSyncInfo.Location = new System.Drawing.Point(12, 229);
            this.lblSyncInfo.Name = "lblSyncInfo";
            this.lblSyncInfo.Size = new System.Drawing.Size(81, 15);
            this.lblSyncInfo.TabIndex = 4;
            this.lblSyncInfo.Text = "sync database";
            this.lblSyncInfo.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 253);
            this.Controls.Add(this.lblSyncInfo);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbConnections);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConnections;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblSyncInfo;
    }
}