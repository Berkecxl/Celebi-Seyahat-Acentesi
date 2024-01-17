using Çelebi_Seyahat_Acentesi.Constant;
using Çelebi_Seyahat_Acentesi.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public static void AddFeatureToUser(User updatedUser)
        {
            List<User> userList = GetUsers();

            User user = getUserByUsername(updatedUser.username);

            if (user != null)
            {
                int index = userList.FindIndex(u => u.username == updatedUser.username);

                if (index != -1)
                {
                    userList[index].waitingTickets = updatedUser.waitingTickets;
                    userList[index].ownReservations = updatedUser.ownReservations;
                    userList[index].ownTickets = updatedUser.ownTickets;

                    SaveUserList(userList);
                }
            }
            else
            {
                //TODO hata mesajı
            }
        }

        private static void SaveUserList(List<User> userList)
        {
            File.WriteAllText(HttpContext.Current.Server.MapPath(Constants.UsersJson), JsonConvert.SerializeObject(userList));
        }

        public static User getUserByUsername(string username)
        {
            List<User> userList = GetUsers();

            return userList.FirstOrDefault(user => user.username == username);
        }
    }
}