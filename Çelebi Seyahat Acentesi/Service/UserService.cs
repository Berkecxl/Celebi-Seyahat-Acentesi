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
    public class UserService
    {
        public static List<User> getUsers()
        {

            string filePath = HttpContext.Current.Server.MapPath(Constants.UsersJson);
            string jsonFile = File.ReadAllText(filePath);

            List<User> userList = JsonConvert.DeserializeObject<List<User>>(jsonFile);
            return userList;
        }
    }
}