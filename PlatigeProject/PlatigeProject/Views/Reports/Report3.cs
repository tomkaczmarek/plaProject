using DataModel.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatigeProject.Views.Reports
{
    public class Report3 : IReport
    {
        private List<Report3Model> _model;
        public string ReportName => "Invoices by contractor";

        public event Action<IReport> OnReportGenerate;

        public void Bind(DataGridView view)
        {
            view.DataSource = _model;
        }

        public async Task Generate()
        {
            _model = await ReportController.GetContractorsInvoiceNetValue();
            OnReportGenerate?.Invoke(this);
        }
    }
}
