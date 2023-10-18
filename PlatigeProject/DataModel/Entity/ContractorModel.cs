using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Entity
{
    public class ContractorModel : IModel
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Country { get; set; }
        public string Adress { get; set; }
        public int NipNumber { get; set; }
        public bool? IsActive { get; set; }     
    }
}
