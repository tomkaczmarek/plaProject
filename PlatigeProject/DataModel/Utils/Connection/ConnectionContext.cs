using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Utils.Connection
{
    [Serializable]
    public class ConnectionContext : IContext
    {

        private static IContext _instance;

        public static IContext Instance 
        {
            get
            {
                if (_instance == null)
                    _instance = new ConnectionContext();
                return _instance;
            }
            private set { }
        }

        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public void CreateConnection(IContext context)
        {
            Server = context.Server;
            Database = context.Database;
            User = context.User;
            Password = context.Password;
        }

        public IContext GetContext()
        {
            return this;
        }

        public string GetConnectionString()
        {
            return $@"Server={Server};Database={Database};User Id={User};Password={Password};Persist Security Info = True";
        }
    }
}
