using Çelebi_Seyahat_Acentesi.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.Model
{
    public class User
    {
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public double point { get; set; }
        public List<Ticket> ownTickets { get; set; }
        public List<Reservation> ownReservations { get; set; }
    }
}