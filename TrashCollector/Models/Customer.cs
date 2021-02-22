using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string PickupDay { get; set; }
        public DateTime SuspendServiceStart { get; set; }
        public DateTime SuspendServiceEnd { get; set; }
        public DateTime AdditionalPickupDay { get; set; }
        public int BalanceDue { get; set; }
    }
}
