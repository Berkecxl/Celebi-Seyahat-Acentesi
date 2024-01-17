using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.ModelBase
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Hotel { get; set; }
        public DateTime Time { get; set; }
        public decimal Price { get; set; }
        public bool isPurchasable { get; set; }
    }
}