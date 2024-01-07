using Çelebi_Seyahat_Acentesi.Model;
using Çelebi_Seyahat_Acentesi.Service;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Çelebi_Seyahat_Acentesi
{
    public partial class TicketList : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CheckUserAccess();
                DisplayTicketList();
            }
        }

        private void DisplayTicketList()
        {
            List<Ticket> tickets = TicketService.getTickets();

            gvTicketList.DataSource = tickets;
            gvTicketList.DataBind();
        }

        private void CheckUserAccess()
        {
            User currentUser = (User)Session["CurrentUser"];

            if (currentUser == null)
            {
                Response.Redirect("Auth.aspx");
            }
        }
    }
}