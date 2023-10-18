using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity
{
    public class InvoiceModel : IModel
    {
        [Key]
        public int Id { get; set; }
        public int ContractorId { get; set; }
        public string Number { get; set; }
        public decimal NetValue { get; set; }
        public string Currency { get; set; }
        public int Vat { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Info { get; set; }

    }
}
