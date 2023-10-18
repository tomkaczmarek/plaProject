using DataModel.Controllers;
using DataModel.Entity;
using PlatigeProject.Views.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlatigeProject.Views
{
    public partial class MainForm : Form
    {
        private ContractorModel _selectedContractor;

        public MainForm()
        {
            InitializeComponent();
            lblProgress.Visible = false;            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count > 0)
            {
                ContractorModel contractorModel = dataView.SelectedRows[0].DataBoundItem as ContractorModel;
                await CommandController<ContractorsController>.GetController().Delete(contractorModel);
                await LoadData();
            }
        }

        private void btnAddNewContractor_Click(object sender, EventArgs e)
        {
            AddUpdateContractorForm addForm = new AddUpdateContractorForm();
            addForm.OnContractorAdd += AddForm_OnContractorAdd;
            addForm.Show();
        }

        private void btnUpdateContractor_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count > 0)
            {
                ContractorModel contractorModel = dataView.SelectedRows[0].DataBoundItem as ContractorModel;
                AddUpdateContractorForm updateForm = new AddUpdateContractorForm(contractorModel);
                updateForm.OnContractorAdd += AddForm_OnContractorAdd;
                updateForm.Show();
            }              
        }

        private async void AddForm_OnContractorAdd()
        {
            await LoadData();
        }


        private async void btnShowAll_Click(object sender, EventArgs e)
        {
            await LoadData(); 
        }

        private async Task LoadData()
        {
            dataView.DataSource = null;
            lblProgress.Visible = true;
            List<ContractorModel> contractorModel = await CommandController<ContractorsController>.GetController().GetAll();
            lblProgress.Visible = false;
            dataView.DataSource = contractorModel;
            EnableInvoiceActions(false);
            EnableContractorActions(true);
        }

        private void EnableContractorActions(bool enable)
        {
            btnAddNewContractor.Enabled = enable;
            btnDeleteContractor.Enabled = enable;
            btnShowContractorInvoice.Enabled = enable;
            btnUpdateContractor.Enabled = enable;
            btnAddInvoice.Enabled = enable;
        }

        private void EnableInvoiceActions(bool enable)
        {
            btnUpdateInvoice.Enabled = enable;
            btnDeleteInvoice.Enabled = enable;
        }

        private async void btnShowAllInvoices_Click(object sender, EventArgs e)
        {
            await LoadInvoice();
        }

        private async Task LoadInvoice()
        {
            dataView.DataSource = null;
            lblProgress.Visible = true;
            List<InvoiceModel> invoiceModel = await CommandController<InvoicesController>.GetController().GetAll();
            lblProgress.Visible = false;
            dataView.DataSource = invoiceModel;
            EnableInvoiceActions(true);
            EnableContractorActions(false);
        }

        private async void btnShowContractorInvoice_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count > 0)
            {
                ContractorModel contractorModel = dataView.SelectedRows[0].DataBoundItem as ContractorModel;
                List<InvoiceModel> model = await CommandController<InvoicesController>.GetController().GetByContractor(contractorModel);
                dataView.DataSource = model;
                _selectedContractor = contractorModel;
            }
        }

        private void btnAddInvoice_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count > 0)
            {
                ContractorModel contractorModel = dataView.SelectedRows[0].DataBoundItem as ContractorModel;
                AddUpdateInvoiceForm form = new AddUpdateInvoiceForm(contractorModel);
                form.OnInvoiceAdd += Form_OnInvoiceAdd;
                form.Show();
            }
        }

        private async void Form_OnInvoiceAdd()
        {
            await LoadInvoice();
        }

        private void btnUpdateInvoice_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count > 0)
            {
                InvoiceModel model = dataView.SelectedRows[0].DataBoundItem as InvoiceModel;
                AddUpdateInvoiceForm updateForm = new AddUpdateInvoiceForm(model, _selectedContractor);
                updateForm.OnInvoiceAdd += Form_OnInvoiceAdd;
                updateForm.Show();
            }
        }

        private async void btnDeleteInvoice_Click(object sender, EventArgs e)
        {
            if (dataView.SelectedRows.Count > 0)
            {
                InvoiceModel model = dataView.SelectedRows[0].DataBoundItem as InvoiceModel;
                await CommandController<InvoicesController>.GetController().Delete(model);
                await LoadInvoice();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportView reportForm = new ReportView();
            reportForm.OnReportGenerate += ReportForm_OnReportGenerate;
            reportForm.Show();
        }

        private void ReportForm_OnReportGenerate(IReport obj)
        {
            obj.Bind(dataView);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
    }
}
