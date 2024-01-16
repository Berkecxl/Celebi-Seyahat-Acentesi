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

        public static Ticket getTicketById(int id)
        {
            List<Ticket> ticketList = getTickets();

            return ticketList.FirstOrDefault(ticket => ticket.Id == id);
        }

        public static bool isTicketSaleSuccess(int id, User user)
        {

            try
            {
                Ticket ticket = getTicketById(id);

                if (ticket != null)
                {
                    ticket.isPurchasable = false;
                    user.ownTickets.Add(ticket);
                    UserService.AddFeatureToUser(user);
                    UpdateTicketPurchaseStatus(ticket);

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void UpdateTicketPurchaseStatus(Ticket updatedTicket)
        {
            List<Ticket> ticketList = getTickets();

            Ticket ticket = getTicketById(updatedTicket.Id);

            if (ticket != null)
            {
                int index = ticketList.FindIndex(t => t.Id == updatedTicket.Id);

                if (index != -1)
                {
                    ticketList[index].isPurchasable = updatedTicket.isPurchasable;

                    SaveTicketList(ticketList);
                }
            }
            else
            {
                //TODO hata mesajı
            }
        }

        private static void SaveTicketList(List<Ticket> ticketList)
        {
            File.WriteAllText(HttpContext.Current.Server.MapPath(Constants.TicketsJson), JsonConvert.SerializeObject(ticketList));
        }
    }
}