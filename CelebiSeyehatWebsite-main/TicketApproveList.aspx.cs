using Çelebi_Seyahat_Acentesi.Model;
using Çelebi_Seyahat_Acentesi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Çelebi_Seyahat_Acentesi
{
    public partial class TicketApproveList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CheckStaffAccess();
                DisplayTicketList();
            }
        }

        private void DisplayTicketList()
        {
            List<Ticket> tickets = TicketService.getTickets();
            List<Ticket> ticketDataSource = new List<Ticket>();

            foreach (Ticket ticket in tickets)
            {
                if (ticket.OwnerUsername != null)
                {
                    ticketDataSource.Add(ticket);
                }
            }

            gvTicketList.DataSource = ticketDataSource;
            gvTicketList.DataBind();
        }

        private void CheckStaffAccess()
        {
            Staff currentStaff = (Staff)Session["CurrentStaff"];

            if (currentStaff == null)
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
            Staff currentUser = (Staff)Session["CurrentStaff"];
            int currentTicketId = (int)Session["CurrentTicketId"];
            Ticket currentTicket = TicketService.getTicketById(currentTicketId);

            if (TicketService.isTicketApproveSuccess(currentTicket, currentUser))
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