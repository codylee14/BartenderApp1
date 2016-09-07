using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BartenderApp.Models
{
    public class DrinkType
    {
        public byte Id { get; set; }
        public short DrinkCost { get; set; }
        public byte NumberOfDrinks { get; set; }
        public byte DiscountRate { get; set; }
    }
}