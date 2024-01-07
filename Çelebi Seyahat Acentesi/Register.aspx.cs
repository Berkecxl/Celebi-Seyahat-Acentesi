using Çelebi_Seyahat_Acentesi.Model;
using Çelebi_Seyahat_Acentesi.Validator;
using System;
using System.Globalization;
using System.Linq;
using System.Web.UI;

namespace Çelebi_Seyahat_Acentesi
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnKayitOl_Click(object sender, EventArgs e)
        {

            CultureInfo cultureInfo = new CultureInfo("tr-TR");
            TextInfo textInfo = cultureInfo.TextInfo;

            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;
            string enteredName = textInfo.ToTitleCase(txtName.Text.ToLower());
            string enteredSurname = textInfo.ToTitleCase(txtSurname.Text.ToLower());

            string validateMessage = RegisterValidator.isValidRegister(enteredUsername, enteredPassword, enteredName, enteredSurname);

            if(validateMessage != null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", $"alert('{validateMessage}');", true);
            }

            
            User user = new User
            {
                username = enteredUsername,
                password = enteredPassword,
                name = enteredName,
                surname = enteredSurname,
                point = 0,
                title = "customer"
            };


        }

        protected void lnkGiris_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auth.aspx");
        }
    }
}