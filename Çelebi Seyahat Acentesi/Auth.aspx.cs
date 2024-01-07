using Çelebi_Seyahat_Acentesi.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Çelebi_Seyahat_Acentesi
{
    public partial class Auth : System.Web.UI.Page
    {
        
            protected void Page_Load(object sender, EventArgs e)
            {
                Session.Remove("CurrentUser");
            }

            protected void btnGiris_Click(object sender, EventArgs e)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (AuthService.IsUserLogin(username, password))
                {
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Kullanıcı adı veya parola yanlış.');", true);
                }
            }

            protected void lnkKayitOl_Click(object sender, EventArgs e)
            {
            Response.Redirect("Register.aspx");
            }

        }
    }