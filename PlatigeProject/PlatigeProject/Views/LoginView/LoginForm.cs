using DataModel.Migrations;
using DataModel.Utils.Connection;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            GetConnectionsList();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            LoginView.AddNewConnectionView addForm = new LoginView.AddNewConnectionView();
            addForm.OnAddConnection += AddForm_OnAddConnection;
            addForm.ShowDialog();
        }

        private void AddForm_OnAddConnection()
        {
            Security.ConnectionSecurity.ConnectionRetriver.SaveConnection(ConnectionContext.Instance.GetContext());
            GetConnectionsList();
        }

        private async  void btnConnect_Click(object sender, EventArgs e)
        {
            lblSyncInfo.Visible = true;
            ConnectionContext.Instance.CreateConnection(Security.ConnectionSecurity.ConnectionRetriver.GetConnection<ConnectionContext>(cbConnections.Text));

            if (!await Creator.CheckIfHasMigration())
                await Creator.CreateMigration();

            lblSyncInfo.Visible = false;
            OpenMainForm();
        }

        private void OpenMainForm()
        {
            this.Visible = false;
            MainForm form = new MainForm();
            form.Show();
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void GetConnectionsList()
        {
            cbConnections.DataSource = Security.ConnectionSecurity.ConnectionRetriver.GetListOfConnections();
        }
    }
}
