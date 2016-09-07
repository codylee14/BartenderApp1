using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace BartenderApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool SingleDouble { get; set; }
        public DrinkType DrinkType { get; set; }
        public byte DrinkTypeId { get; set; }
    }
}