using DataModel.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatigeProject.Views.Reports
{
    public interface IReport
    {
        public event Action<IReport> OnReportGenerate;
        public string ReportName { get;  }
        public Task Generate();
        public void Bind(DataGridView view);
    }
}
