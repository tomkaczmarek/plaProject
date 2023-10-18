
using DataModel.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Context
{
    public class PlatigeDbContext : DbContext
    {
        public PlatigeDbContext(string connectionsString) : base(connectionsString)
        {
            this.Database.Connection.Open();
        }
        public DbSet<ContractorModel> Contractor { get; set; }
        public DbSet<InvoiceModel> Invoice { get; set; }
    }
}
