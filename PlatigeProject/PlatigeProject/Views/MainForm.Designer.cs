
namespace PlatigeProject.Views
{
    partial class MainForm
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
            this.btnDeleteContractor = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNewContractor = new System.Windows.Forms.Button();
            this.btnUpdateContractor = new System.Windows.Forms.Button();
            this.btnShowAllContractors = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnShowContractorInvoice = new System.Windows.Forms.Button();
            this.btnShowAllInvoices = new System.Windows.Forms.Button();
            this.btnUpdateInvoice = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteContractor
            // 
            this.btnDeleteContractor.Enabled = false;
            this.btnDeleteContractor.Location = new System.Drawing.Point(841, 406);
            this.btnDeleteContractor.Name = "btnDeleteContractor";
            this.btnDeleteContractor.Size = new System.Drawing.Size(148, 23);
            this.btnDeleteContractor.TabIndex = 0;
            this.btnDeleteContractor.Text = "Delete contractor";
            this.btnDeleteContractor.UseVisualStyleBackColor = true;
            this.btnDeleteContractor.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 27);
            this.dataView.MultiSelect = false;
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowTemplate.Height = 25;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(1307, 373);
            this.dataView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Type";
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Name";
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ShortName";
            this.Column4.HeaderText = "ShortName";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Country";
            this.Column5.HeaderText = "Country";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Adress";
            this.Column6.HeaderText = "Adress";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NipNumber";
            this.Column7.HeaderText = "NipNumber";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // btnAddNewContractor
            // 
            this.btnAddNewContractor.Enabled = false;
            this.btnAddNewContractor.Location = new System.Drawing.Point(455, 406);
            this.btnAddNewContractor.Name = "btnAddNewContractor";
            this.btnAddNewContractor.Size = new System.Drawing.Size(157, 23);
            this.btnAddNewContractor.TabIndex = 2;
            this.btnAddNewContractor.Text = "Add new contractor";
            this.btnAddNewContractor.UseVisualStyleBackColor = true;
            this.btnAddNewContractor.Click += new System.EventHandler(this.btnAddNewContractor_Click);
            // 
            // btnUpdateContractor
            // 
            this.btnUpdateContractor.Enabled = false;
            this.btnUpdateContractor.Location = new System.Drawing.Point(455, 435);
            this.btnUpdateContractor.Name = "btnUpdateContractor";
            this.btnUpdateContractor.Size = new System.Drawing.Size(157, 23);
            this.btnUpdateContractor.TabIndex = 3;
            this.btnUpdateContractor.Text = "Update contractor";
            this.btnUpdateContractor.UseVisualStyleBackColor = true;
            this.btnUpdateContractor.Click += new System.EventHandler(this.btnUpdateContractor_Click);
            // 
            // btnShowAllContractors
            // 
            this.btnShowAllContractors.Location = new System.Drawing.Point(13, 405);
            this.btnShowAllContractors.Name = "btnShowAllContractors";
            this.btnShowAllContractors.Size = new System.Drawing.Size(173, 23);
            this.btnShowAllContractors.TabIndex = 4;
            this.btnShowAllContractors.Text = "Show all contractors";
            this.btnShowAllContractors.UseVisualStyleBackColor = true;
            this.btnShowAllContractors.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(1260, 443);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(59, 15);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "working...";
            this.lblProgress.Visible = false;
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Enabled = false;
            this.btnAddInvoice.Location = new System.Drawing.Point(653, 405);
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(162, 23);
            this.btnAddInvoice.TabIndex = 6;
            this.btnAddInvoice.Text = "Add invoice";
            this.btnAddInvoice.UseVisualStyleBackColor = true;
            this.btnAddInvoice.Click += new System.EventHandler(this.btnAddInvoice_Click);
            // 
            // btnShowContractorInvoice
            // 
            this.btnShowContractorInvoice.Enabled = false;
            this.btnShowContractorInvoice.Location = new System.Drawing.Point(13, 433);
            this.btnShowContractorInvoice.Name = "btnShowContractorInvoice";
            this.btnShowContractorInvoice.Size = new System.Drawing.Size(173, 23);
            this.btnShowContractorInvoice.TabIndex = 7;
            this.btnShowContractorInvoice.Text = "Show contractor invoices";
            this.btnShowContractorInvoice.UseVisualStyleBackColor = true;
            this.btnShowContractorInvoice.Click += new System.EventHandler(this.btnShowContractorInvoice_Click);
            // 
            // btnShowAllInvoices
            // 
            this.btnShowAllInvoices.Location = new System.Drawing.Point(192, 405);
            this.btnShowAllInvoices.Name = "btnShowAllInvoices";
            this.btnShowAllInvoices.Size = new System.Drawing.Size(170, 23);
            this.btnShowAllInvoices.TabIndex = 8;
            this.btnShowAllInvoices.Text = "Show all invoices";
            this.btnShowAllInvoices.UseVisualStyleBackColor = true;
            this.btnShowAllInvoices.Click += new System.EventHandler(this.btnShowAllInvoices_Click);
            // 
            // btnUpdateInvoice
            // 
            this.btnUpdateInvoice.Enabled = false;
            this.btnUpdateInvoice.Location = new System.Drawing.Point(653, 435);
            this.btnUpdateInvoice.Name = "btnUpdateInvoice";
            this.btnUpdateInvoice.Size = new System.Drawing.Size(162, 23);
            this.btnUpdateInvoice.TabIndex = 9;
            this.btnUpdateInvoice.Text = "Update invoice";
            this.btnUpdateInvoice.UseVisualStyleBackColor = true;
            this.btnUpdateInvoice.Click += new System.EventHandler(this.btnUpdateInvoice_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Enabled = false;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(841, 435);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(148, 23);
            this.btnDeleteInvoice.TabIndex = 10;
            this.btnDeleteInvoice.Text = "Delete invoice";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(1201, 406);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(118, 23);
            this.btnReports.TabIndex = 11;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 461);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnUpdateInvoice);
            this.Controls.Add(this.btnShowAllInvoices);
            this.Controls.Add(this.btnShowContractorInvoice);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnShowAllContractors);
            this.Controls.Add(this.btnUpdateContractor);
            this.Controls.Add(this.btnAddNewContractor);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.btnDeleteContractor);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteContractor;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
        private System.Windows.Forms.Button btnAddNewContractor;
        private System.Windows.Forms.Button btnUpdateContractor;
        private System.Windows.Forms.Button btnShowAllContractors;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnShowContractorInvoice;
        private System.Windows.Forms.Button btnShowAllInvoices;
        private System.Windows.Forms.Button btnUpdateInvoice;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnReports;
    }
}