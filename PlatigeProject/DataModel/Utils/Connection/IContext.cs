﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Utils.Connection
{
    public interface IContext
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public void CreateConnection(IContext context);

        public string GetConnectionString();

        public IContext GetContext();
    }
}
