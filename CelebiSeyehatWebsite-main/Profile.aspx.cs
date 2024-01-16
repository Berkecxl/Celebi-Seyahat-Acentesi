using Çelebi_Seyahat_Acentesi.Model;
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
                Response.Redirect("Auth.aspx");
            }

            lblUsername.Text = currentUser.username;
            lblName.Text = currentUser.name;
            lblSurname.Text = currentUser.surname;
            lblPoint.Text = currentUser.point.ToString();

            phCustomerId.Visible = false;
            phStaffId.Visible = false;
            phWorkingPlace.Visible = false;

            if (currentUser is Customer customer)
            {
                lblCustomerId.Text = customer.customerId.ToString();

                phCustomerId.Visible = true;
            }

            if (currentUser is Staff staff)
            {
                lblStaffId.Text = staff.staffId.ToString();
                lblWorkingPlace.Text = staff.workingPlace;

                phStaffId.Visible = true;
                phWorkingPlace.Visible = true;
            }
        }

    }
}