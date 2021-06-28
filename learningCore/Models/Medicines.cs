using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace learningCore.Models
{
    public class Medicines
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }
       
        public int Quantity { get; set; }

        public DateTime Expiry { get; set; }

        public string Notes { get; set; }

    }
}
