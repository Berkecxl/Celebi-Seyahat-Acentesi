using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.Model
{
    public class Staff : User
    {
        public int staffId { get; set; }
        public string workingPlace { get; set; }
    }
}