using DataModel.Context;
using DataModel.Entity;
using DataModel.Utils.Connection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Controllers
{
    public class InvoicesController : AbstractCommand<InvoiceModel>
    {
        public async override Task Add(InvoiceModel item)
        {
            await Task.Run(() =>
            {
                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {
                    context.Invoice.Add(item);
                    context.SaveChanges();
                }
            });
        }

        public async override Task Delete(InvoiceModel item)
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

        public async override Task<InvoiceModel> Get(int id)
        {

            return await Task.Run(() =>
            {
                InvoiceModel model = new InvoiceModel();

                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {
                    model = context.Invoice.Where(x => x.Id == id).Select(x => x).FirstOrDefault();
                }
                return model;
            });
        }

        public async override Task<List<InvoiceModel>> GetAll()
        {
            return await Task.Run(() =>
            {
                List<InvoiceModel> model = new List<InvoiceModel>();

                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {
                    model = context.Invoice.ToList();
                }
                return model;
            });
        }

        public async override Task Update(InvoiceModel item)
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

        public async Task<List<InvoiceModel>> GetByContractor(ContractorModel item)
        {
            return await Task.Run(() =>
            {
                List<InvoiceModel> model = new List<InvoiceModel>();
                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {
                    model = context.Invoice.Where(x => x.ContractorId == item.Id).Select(x => x).ToList();
                }

                return model;
            });
        }
    }
}
