using Çelebi_Seyahat_Acentesi.Model;
using System;
using System.Web.UI;

namespace Çelebi_Seyahat_Acentesi
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            profile.Visible = false;   
            logout.Visible = false;
            CheckAccess();
        }

        private void CheckAccess()
        {
            var user = Session["CurrentUser"];
            var staff = Session["CurrentStaff"];

            if (user != null || staff != null)
            {
                logout.Visible = true;
                profile.Visible = true;
                signIn.Visible = false;
            }
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session.Clear(); 
            Session.Abandon(); 

            Response.Redirect("~/AuthBase.aspx"); 
        }

    }
}