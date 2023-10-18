using DataModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Controllers
{
    public abstract class AbstractCommand<T> where T : IModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public abstract Task Add(T item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public abstract  Task Update(T item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public abstract Task<T> Get(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract Task<List<T>> GetAll();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public abstract Task Delete(T item);

    }
}
