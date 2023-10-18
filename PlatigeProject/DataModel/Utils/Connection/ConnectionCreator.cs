using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Utils.Connection
{
    public class ConnectionCreator : IConnectionCreator
    {
        private IContext _context;

        public ConnectionCreator(IContext context)
        {
            _context = context;
        }

        public void AddConnectionContext()
        {
            
        }

        public IContext GetConnectionContext()
        {
            return _context;
        }
    }
}
