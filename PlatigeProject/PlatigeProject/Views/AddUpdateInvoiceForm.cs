using DataModel.Controllers;
using DataModel.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatigeProject.Views
{
    public partial class AddUpdateInvoiceForm : Form
    {
        private InvoiceModel _model;
        private ContractorModel _contractor;

        public event Action OnInvoiceAdd;

        public AddUpdateInvoiceForm(ContractorModel contractor)
        {
            _contractor = contractor;
            InitializeComponent();
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        }

        public AddUpdateInvoiceForm(InvoiceModel model, ContractorModel contractor)
        {
            _model = model;
            _contractor = contractor;
            InitializeComponent();
            this.btnSave.Click += new System.EventHandler(this.btnUpdate_Click);
            BindModel(model);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            InvoiceModel model = new InvoiceModel();
            GetModelToSave(model);
            await CommandController<InvoicesController>.GetController().Add(model);
            OnInvoiceAdd?.Invoke();
            this.Close();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            GetModelToSave(_model);
            await CommandController<InvoicesController>.GetController().Update(_model);
            OnInvoiceAdd?.Invoke();
            this.Close();
        }

        private void BindModel(InvoiceModel model)
        {
            txtCurrency.Text = model.Currency;
            txtInfo.Text = model.Info;
            txtNetValue.Text = $"{model.NetValue}"; 
            txtNumber.Text = model.Number;
            dtTrans.Value = model.TransactionDate;
            txtVat.Text = $"{model.Vat}"; ;
        }

        private void GetModelToSave(InvoiceModel model)
        {
            model.Currency = txtCurrency.Text;
            model.Info = txtInfo.Text;
            model.NetValue = Convert.ToDecimal(txtNetValue.Text);
            model.Number = txtNumber.Text;
            model.TransactionDate = dtTrans.Value;
            model.Vat = Convert.ToInt32(txtVat.Text);
            model.ContractorId = _contractor.Id;
        }
    }
}
