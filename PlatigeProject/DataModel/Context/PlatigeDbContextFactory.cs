using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Context
{
    public class PlatigeDbContextFactory : IDbContextFactory<PlatigeDbContext>
    {
        public PlatigeDbContext Create()
        {
            return new PlatigeDbContext(DataModel.Utils.Connection.ConnectionContext.Instance.GetConnectionString());
        }
    }
}
