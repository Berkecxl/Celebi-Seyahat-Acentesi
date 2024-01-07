using Çelebi_Seyahat_Acentesi.Constant;
using Çelebi_Seyahat_Acentesi.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Web;

namespace Çelebi_Seyahat_Acentesi.Service
{
    public class UserService
    {
        public static List<User> GetUsers()
        {

            string filePath = HttpContext.Current.Server.MapPath(Constants.UsersJson);
            string jsonFile = File.ReadAllText(filePath);

            List<User> userList = JsonConvert.DeserializeObject<List<User>>(jsonFile);
            return userList;
        }

        public static void AddUser(User user)
        {
            List<User> userList = GetUsers();
            userList.Add(user);
            File.WriteAllText(HttpContext.Current.Server.MapPath(Constants.UsersJson), JsonConvert.SerializeObject(userList));
        }
    }
}