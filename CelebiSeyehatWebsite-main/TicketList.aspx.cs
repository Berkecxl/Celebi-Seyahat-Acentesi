using Çelebi_Seyahat_Acentesi.Model;
using Çelebi_Seyahat_Acentesi.Service;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Web.Optimization;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                Response.Redirect("AuthBase.aspx");
            }
        }

        protected void btnReserve_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;

            string ticketId = gvTicketList.DataKeys[gvr.RowIndex].Values["Id"].ToString();
            Session["CurrentTicketId"] = Convert.ToInt32(ticketId);
            pnlConfirmModal.Style["display"] = "block";
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string message;
            User currentUser = (User)Session["CurrentUser"];
            int currentTicketId = (int)Session["CurrentTicketId"];

            if (TicketService.isTicketSaleSuccess(currentTicketId, currentUser))
            {
            }
            else
            {
            }


            Thread.Sleep(3000);
            Response.Redirect(Request.RawUrl);
        }



    }
}
