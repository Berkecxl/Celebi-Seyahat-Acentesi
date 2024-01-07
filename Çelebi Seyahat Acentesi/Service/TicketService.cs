using Çelebi_Seyahat_Acentesi.Constant;
using Çelebi_Seyahat_Acentesi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.Service
{
    public class TicketService
    {
        public static List<Ticket> getTickets()
        {
            string filePath = HttpContext.Current.Server.MapPath(Constants.TicketsJson);
            string jsonFile = File.ReadAllText(filePath);

            List<Ticket> ticketList = JsonConvert.DeserializeObject<List<Ticket>>(jsonFile);
            return ticketList;
        }
    }
}