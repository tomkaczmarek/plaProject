
namespace PlatigeProject.Views
{
    partial class AddUpdateInvoiceForm
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtNetValue = new System.Windows.Forms.TextBox();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.dtTrans = new System.Windows.Forms.DateTimePicker();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(101, 34);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(219, 23);
            this.txtNumber.TabIndex = 0;
            // 
            // txtNetValue
            // 
            this.txtNetValue.Location = new System.Drawing.Point(101, 63);
            this.txtNetValue.Name = "txtNetValue";
            this.txtNetValue.Size = new System.Drawing.Size(219, 23);
            this.txtNetValue.TabIndex = 1;
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(101, 92);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(219, 23);
            this.txtCurrency.TabIndex = 2;
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(101, 122);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(219, 23);
            this.txtVat.TabIndex = 3;
            // 
            // dtTrans
            // 
            this.dtTrans.Location = new System.Drawing.Point(101, 152);
            this.dtTrans.Name = "dtTrans";
            this.dtTrans.Size = new System.Drawing.Size(219, 23);
            this.dtTrans.TabIndex = 4;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(101, 182);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(219, 23);
            this.txtInfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Net Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Transaction date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Info";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(245, 216);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddUpdateInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 251);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.dtTrans);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtNetValue);
            this.Controls.Add(this.txtNumber);
            this.Name = "AddUpdateInvoiceForm";
            this.Text = "AddUpdateInvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtNetValue;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.DateTimePicker dtTrans;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
    }
}