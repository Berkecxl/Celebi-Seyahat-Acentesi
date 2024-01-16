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
            CheckUserAccess();
        }

        private void CheckUserAccess()
        {
            var user = Session["CurrentUser"];

            if (user != null)
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

            Response.Redirect("~/Auth.aspx"); 
        }

    }
}