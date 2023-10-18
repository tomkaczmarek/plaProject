using DataModel.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatigeProject.Views.Reports
{
    public partial class ReportView : Form
    {
        List<IReport> _reportsList;
        public event Action<IReport> OnReportGenerate; 
        public ReportView()
        {
            InitializeComponent();
            RegisterReports();
        }

        private void RegisterReports()
        {
            _reportsList = new List<IReport>();
            _reportsList.Add(new Report1());
            _reportsList.Add(new Report2());
            _reportsList.Add(new Report3());

            comboBox1.DataSource = _reportsList.Select(x => x.ReportName).ToList();
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            string reportName = comboBox1.SelectedValue.ToString();

            IReport report = _reportsList.Where(x => x.ReportName == reportName).Select(x => x).FirstOrDefault();

            if(report != null)
            {
                report.OnReportGenerate += Report_OnReportGenerate;
                await report.Generate();
            }
        }

        private void Report_OnReportGenerate(IReport obj)
        {
            OnReportGenerate?.Invoke(obj);
        }
    }
}
