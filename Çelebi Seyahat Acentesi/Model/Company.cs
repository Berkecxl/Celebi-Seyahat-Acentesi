using Çelebi_Seyahat_Acentesi.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.Model
{
    public class Company : Merchant
    {
        public List<Ticket> TicketList { get; set; }
    }
}