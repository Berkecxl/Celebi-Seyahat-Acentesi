using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.Model
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public DateTime Time { get; set; }
        public string ExitPoint { get; set; }
        public string DestinationPoint { get; set; }
        public decimal Price { get; set; }
        public bool isPurchasable { get; set;}
    }
}