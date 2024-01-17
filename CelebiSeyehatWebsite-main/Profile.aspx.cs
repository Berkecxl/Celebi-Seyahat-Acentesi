using Çelebi_Seyahat_Acentesi.Model;
using Çelebi_Seyahat_Acentesi.ModelBase;
using System;
using System.Web.UI;

namespace Çelebi_Seyahat_Acentesi
{
    public partial class Profile : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUserAccess();
        }

        private void CheckUserAccess()
        {
            var currentUser = Session["CurrentUser"] as User;

            if (currentUser == null)
            {
                var currentStaff = Session["CurrentStaff"] as Staff;
                
                if(currentStaff == null)
                {
                    Response.Redirect("Auth.aspx");
                }

                lblStaffId.Text = currentStaff.staffId.ToString();
                lblName.Text = currentStaff.name;
                lblSurname.Text = currentStaff.surname;
                lblWorkingPlace.Text = currentStaff.workingPlace;

                phOwnReservations.Visible = false;
                phOwnTickets.Visible = false;
                phPoint.Visible = false;
                phUsername.Visible = false;

                phStaffId.Visible = true;
                phWorkingPlace.Visible = true;
            }
            else
            {
                lblUsername.Text = currentUser.username;
                lblName.Text = currentUser.name;
                lblSurname.Text = currentUser.surname;
                lblPoint.Text = currentUser.point.ToString();

                if (currentUser.ownTickets.Count > 0)
                {
                    string ticketMessage = "";
                    foreach(Ticket ticket in currentUser.ownTickets)
                    {
                        ticketMessage += $"Şirket: {ticket.Company}     Tarih: {ticket.Time.ToString("dd MMMM yyyy 'saat' HH:mm")} \n";
                    }
                    lblOwnTickets.Text = ticketMessage;
                }
                else {
                    lblOwnTickets.Text = "Biletiniz Bulunmamaktadır.";
                }

                if (currentUser.ownReservations.Count > 0)
                {
                    string reservationMessage = "";
                    foreach (Reservation reservation in currentUser.ownReservations)
                    {
                        reservationMessage += $"Otel: {reservation.Hotel}     Tarih: {reservation.Time.ToString("dd MMMM yyyy 'saat' HH:mm")} \n";
                    }
                    lblOwnReservations.Text = reservationMessage;
                }
                else
                {
                    lblOwnReservations.Text = "Rezervasyonunuz Bulunmamaktadır.";
                }

                phStaffId.Visible = false;
                phWorkingPlace.Visible = false;
            }
        }

    }
}