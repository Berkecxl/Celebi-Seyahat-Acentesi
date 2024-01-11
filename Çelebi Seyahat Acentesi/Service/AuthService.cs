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

            if (user.userType == "staff")
            {
                List<Staff> staffList = JsonConvert.DeserializeObject<List<Staff>>(jsonFile);
                Staff staffUser = staffList.Find(u => u.username == username && u.password == password);
                HttpContext.Current.Session["CurrentUser"] = staffUser;
            }
            else
            {
                List<Customer> customerList = JsonConvert.DeserializeObject<List<Customer>>(jsonFile);
                Customer customerUser = customerList.Find(u => u.username == username && u.password == password);
                HttpContext.Current.Session["CurrentUser"] = customerUser;
            }

            return true;
        }

    }
}