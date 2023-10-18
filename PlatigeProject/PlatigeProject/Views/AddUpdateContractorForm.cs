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
    public partial class AddUpdateContractorForm : Form
    {
        private ContractorModel _model;

        public event Action OnContractorAdd;

        public AddUpdateContractorForm()
        {
            InitializeComponent();
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
        }
        
        public AddUpdateContractorForm(ContractorModel model)
        {
            _model = model;
            InitializeComponent();
            this.btnSave.Click += new System.EventHandler(this.btnUpdate_Click);
            BindModel(model);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            ContractorModel model = new ContractorModel();
            GetModelToSave(model);
            await CommandController<ContractorsController>.GetController().Add(model);
            OnContractorAdd?.Invoke();
            this.Close();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            GetModelToSave(_model);
            await CommandController<ContractorsController>.GetController().Update(_model);
            OnContractorAdd?.Invoke();
            this.Close();
        }

        private void BindModel(ContractorModel model)
        {
            txtNip.Text = $"{model.NipNumber}";
            txtName.Text = model.Name;
            txtShortName.Text = model.ShortName;
            txtAdress.Text = model.Adress;
            txtCountry.Text = model.Country;
            chIsActive.Checked = model.IsActive.GetValueOrDefault();
            txtType.Text = model.Type;
        }

        private void GetModelToSave(ContractorModel model)
        {
            model.Name = txtName.Text;
            model.ShortName = txtShortName.Text;
            model.Adress = txtAdress.Text;
            model.Country = txtCountry.Text;
            model.IsActive = chIsActive.Checked;
            model.Type = txtType.Text;
        }
    }
}
