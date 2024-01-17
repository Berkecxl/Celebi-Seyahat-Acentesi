using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Çelebi_Seyahat_Acentesi
{
    public partial class AuthBase : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Remove("CurrentUser");
            Session.Remove("CurrentStaff");
        }

        protected void lnkStaffSign_Click(object sender, EventArgs e)
        {
            Response.Redirect("AuthStaff.aspx");
        }

        protected void lnkUserSign_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auth.aspx");
        }
    }
}