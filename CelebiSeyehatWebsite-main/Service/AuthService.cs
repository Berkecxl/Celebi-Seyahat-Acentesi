using Çelebi_Seyahat_Acentesi.Constant;
using Çelebi_Seyahat_Acentesi.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.Service
{
    public class AuthService
    {
        public static bool IsUserLogin(string username, string password)
        {
            string filePath = HttpContext.Current.Server.MapPath(Constants.UsersJson);

            string jsonFile = File.ReadAllText(filePath);
            List<User> userList = JsonConvert.DeserializeObject<List<User>>(jsonFile);
            User user = userList.Find(u => u.username == username && u.password == password);

            if (user == null)
            {
                return false;
            }
            
            HttpContext.Current.Session["CurrentUser"] = user;
            return true;
        }
        public static bool IsStaffLogin(string staffId, string password)
        {
            string filePath = HttpContext.Current.Server.MapPath(Constants.StaffsJson);

            string jsonFile = File.ReadAllText(filePath);
            List<Staff> staffList = JsonConvert.DeserializeObject<List<Staff>>(jsonFile);
            Staff staff = staffList.Find(s => s.staffId == Convert.ToInt64(staffId) && s.password == password);

            if (staff == null)
            {
                return false;
            }

            HttpContext.Current.Session["CurrentStaff"] = staff;
            return true;
        }
    }
}