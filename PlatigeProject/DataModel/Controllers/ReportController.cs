using DataModel.Context;
using DataModel.Utils.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Controllers
{
    public class ReportModel
    { }

    public class Report1Model : ReportModel
    {
        public int ContractorsCount { get; set; }
        public string Country { get; set; }
    }

    public class Report2Model : ReportModel
    {
        public decimal NetValue { get; set; }

        public int MonthNumber { get; set; }
    }

    public class Report3Model : ReportModel
    {
        public decimal NetValue { get; set; }
        public string Name { get; set; }
        public int InvoiceCount { get; set; }
    }

    public class ReportController
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Report1Model>> GetContractorByCountryReport()
        {
            return await Task.Run(() => 
            {
                List<Report1Model> model = new List<Report1Model>();
                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {
                    model = context.Database.SqlQuery<Report1Model>(@"SELECT count(*) ContractorsCount, Country
                                                FROM [dbo].[ContractorModels] group by Country").ToList();
                }
                return model;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Report2Model>> GetNetValueByMonth()
        {
            return await Task.Run(() =>
            {
                List<Report2Model> model = new List<Report2Model>();
                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {
                    model = context.Database.SqlQuery<Report2Model>(@"select SUM([NetValue]) as NetValue , MONTH([TransactionDate]) MonthNumber 
                        from [dbo].[InvoiceModels] group by MONTH([TransactionDate])").ToList();
                }
                return model;
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task<List<Report3Model>> GetContractorsInvoiceNetValue()
        {
            return await Task.Run(() =>
            {
                List<Report3Model> model = new List<Report3Model>();
                using (PlatigeDbContext context = new PlatigeDbContext(ConnectionContext.Instance.GetConnectionString()))
                {
                    model = context.Database.SqlQuery<Report3Model>(@"SELECT 
                                                                 [Name],
                                                            	  count(*) as InvoiceCount
                                                                 ,SUM([NetValue]) as NetValue
                                                             FROM [dbo].[ContractorModels]
                                                             JOIN [dbo].[InvoiceModels] ON [ContractorModels].Id = [InvoiceModels].[ContractorId] group by [Name]").ToList();
                }
                return model;
            });
        }


    }
}
