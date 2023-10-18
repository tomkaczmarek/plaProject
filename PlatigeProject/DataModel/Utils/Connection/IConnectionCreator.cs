using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Utils.Connection
{
    public interface IConnectionCreator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IContext GetConnectionContext();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connectionContext"></param>
        public void AddConnectionContext();
    }
}
