using Çelebi_Seyahat_Acentesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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