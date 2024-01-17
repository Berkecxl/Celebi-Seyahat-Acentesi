using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.Model
{
    public class Log
    {
        public int Id { get; set; }
        public string Merchant { get; set; }
        public string Username { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}