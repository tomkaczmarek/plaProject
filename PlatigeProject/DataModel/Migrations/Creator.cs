using DataModel.Context;
using DataModel.Controllers;
using DataModel.Utils.Connection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Migrations
{
    public class Creator
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> CheckIfHasMigration()
        {
            return await ContractorsController.IsExist();
        }

        public static async Task CreateMigration()
        {
            await Task.Run(() =>
            {
                Database.SetInitializer(new MigrateDatabaseToLatestVersion<PlatigeDbContext, Configuration>());               
            });
        }
    }
}
