using DataModel.Context;
using DataModel.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DataModel.Utils.Connection;

namespace DataModel.Controllers
{
    public class ContractorsController : AbstractCommand<ContractorModel>
    {
        public async static Task<bool> IsExist()
        {
            return await Task.Run(() => 
            {
                bool exists = false;
                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {

                     exists = context.Database
                         .SqlQuery<int?>(@"
                         SELECT 1 FROM sys.tables AS T
                         INNER JOIN sys.schemas AS S ON T.schema_id = S.schema_id
                         WHERE S.Name = 'dbo' AND T.Name = 'ContractorModels'")
                         .SingleOrDefault() != null;
                }

                return exists;
            });         
        }

        public override async Task Add(ContractorModel item)
        {
             await Task.Run(() => 
             {
                 using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                 {
                     context.Contractor.Add(item);
                     context.SaveChanges();
                 }
             });
        }

        public override async Task Delete(ContractorModel item)
        {
            await Task.Run(() => 
            {
                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {
                    context.Entry(item).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            });
        }

        public override async Task<ContractorModel> Get(int id)
        {
             return await Task.Run(() => 
             {
                 ContractorModel model = new ContractorModel();

                 using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                 {
                     model = context.Contractor.Where(x => x.Id == id).Select(x => x).FirstOrDefault();
                 }
                 return model;
             });
        }

        public override async Task<List<ContractorModel>> GetAll()
        {
            return await Task.Run(() =>
            {
                List<ContractorModel> model = new List<ContractorModel>();

                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {
                    model = context.Contractor.ToList();
                }
                return model;
            });
        }

        public override async Task Update(ContractorModel item)
        {
            await Task.Run(() => 
            {
                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {
                    context.Entry(item).State = EntityState.Modified;
                    context.SaveChanges();
                }
            });
        }
    }
}
