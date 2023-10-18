
namespace PlatigeProject.Views
{
    partial class AddUpdateContractorForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtNip = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chIsActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(143, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(423, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(143, 74);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(423, 23);
            this.txtShortName.TabIndex = 1;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(143, 103);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(423, 23);
            this.txtAdress.TabIndex = 2;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(143, 132);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(423, 23);
            this.txtCountry.TabIndex = 3;
            // 
            // txtNip
            // 
            this.txtNip.Location = new System.Drawing.Point(143, 161);
            this.txtNip.Name = "txtNip";
            this.txtNip.Size = new System.Drawing.Size(423, 23);
            this.txtNip.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(98, 48);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(39, 15);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Short name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adress";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "NIP";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(143, 191);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(423, 23);
            this.txtType.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type";
            // 
            // chIsActive
            // 
            this.chIsActive.AutoSize = true;
            this.chIsActive.Location = new System.Drawing.Point(143, 220);
            this.chIsActive.Name = "chIsActive";
            this.chIsActive.Size = new System.Drawing.Size(70, 19);
            this.chIsActive.TabIndex = 12;
            this.chIsActive.Text = "Is Active";
            this.chIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(491, 279);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddUpdateContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 314);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chIsActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNip);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtShortName);
            this.Controls.Add(this.txtName);
            this.Name = "AddUpdateContractorForm";
            this.Text = "AddUpdateContractorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtNip;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chIsActive;
        private System.Windows.Forms.Button btnSave;
    }
}