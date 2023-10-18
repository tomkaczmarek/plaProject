using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Controllers
{
    public class CommandController<T> where  T : new()
    {
        public static T GetController()
        {
            return new T();
        }
    }
}
