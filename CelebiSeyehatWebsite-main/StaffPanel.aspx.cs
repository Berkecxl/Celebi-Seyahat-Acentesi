using Çelebi_Seyahat_Acentesi.Model;
using Çelebi_Seyahat_Acentesi.Service;
using System;
using System.Collections.Generic;

namespace Çelebi_Seyahat_Acentesi
{
    public partial class StaffPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckStaffAccess();
            List<Log> LogList = LogService.GetLogs();

            repeaterLogs.DataSource = LogList;
            repeaterLogs.DataBind();
        }

        private void CheckStaffAccess()
        {
            Staff currentStaff = (Staff)Session["CurrentStaff"];

            if (currentStaff == null)
            {
                Response.Redirect("AuthBase.aspx");
            }
        }


    }
}