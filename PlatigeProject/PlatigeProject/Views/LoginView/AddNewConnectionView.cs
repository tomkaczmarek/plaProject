using DataModel.Utils.Connection;
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

namespace PlatigeProject.Views.LoginView
{
    public partial class AddNewConnectionView : Form
    {
        public event Action OnAddConnection;

        public AddNewConnectionView()
        {
            InitializeComponent();
            btnAddConnection.Enabled = false;
            lblTest.Visible = false;
        }

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            this.Close();
            OnAddConnection?.Invoke();
        }

        private async void btnTestConnection_Click(object sender, EventArgs e)
        {
            lblTest.Visible = true;
            bool isValid = await TestConnection();
            btnAddConnection.Enabled = isValid;
            lblTest.Visible = false;
        }

        private async Task<bool> TestConnection()
        {
            return await Task.Run(() =>
            {
                IContext connectionContext = new ConnectionContext()
                {
                    Server = txtServer.Text,
                    Database = txtDatabase.Text,
                    Password = txtPassword.Text,
                    User = txtUser.Text
                };
                ConnectionContext.Instance.CreateConnection(connectionContext);
                string connectionString = ConnectionContext.Instance.GetConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        if(connection.State == ConnectionState.Open)
                            connection.Close();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
            );
        }
    }
}
