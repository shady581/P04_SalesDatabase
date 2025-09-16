using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase
{
    internal class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(80)]
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
