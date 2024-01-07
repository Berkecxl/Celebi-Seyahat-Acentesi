using Çelebi_Seyahat_Acentesi.Model;
using System;
using System.Web.UI;

namespace Çelebi_Seyahat_Acentesi
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUserAccess();
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