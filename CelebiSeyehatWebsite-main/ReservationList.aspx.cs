using Çelebi_Seyahat_Acentesi.Model;
using Çelebi_Seyahat_Acentesi.ModelBase;
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
    public partial class ReservationList : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CheckUserAccess();
                DisplayReservationList();
            }
        }

        private void DisplayReservationList()
        {
            List<Reservation> reservations = ReservationService.getReservations();

            gvReservationList.DataSource = reservations;
            gvReservationList.DataBind();
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

            string reservationId = gvReservationList.DataKeys[gvr.RowIndex].Values["Id"].ToString();
            Session["CurrentReservationId"] = Convert.ToInt32(reservationId);
            pnlConfirmModal.Style["display"] = "block";
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string message;
            User currentUser = (User)Session["CurrentUser"];
            int currentReservationId = (int)Session["CurrentReservationId"];

            if (ReservationService.isReservationSuccess(currentReservationId, currentUser))
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