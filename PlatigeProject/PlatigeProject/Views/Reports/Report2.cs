using DataModel.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatigeProject.Views.Reports
{
    public class Report2 : IReport
    {
        private List<Report2Model> _model;
        public string ReportName => "NetValue by month";

        public event Action<IReport> OnReportGenerate;

        public void Bind(DataGridView view)
        {
            view.DataSource = _model;
        }

        public async Task Generate()
        {
            _model = await ReportController.GetNetValueByMonth();
            OnReportGenerate?.Invoke(this);
        }
    }
}
