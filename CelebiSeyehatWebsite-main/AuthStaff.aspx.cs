using Çelebi_Seyahat_Acentesi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Çelebi_Seyahat_Acentesi
{
    public partial class AuthStaff : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("CurrentStaff");
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            string password = txtPassword.Text;

            if (AuthService.IsStaffLogin(staffId, password))
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                loginError.Visible = true;
            }
        }

        protected void lnkKayitOl_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}