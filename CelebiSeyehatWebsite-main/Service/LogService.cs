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
    public class LogService
    {
        public static List<Log> GetLogs()
        {
            string logFilePath = HttpContext.Current.Server.MapPath(Constants.LogsJson);
            List<Log> logs = new List<Log>();

            if (File.Exists(logFilePath))
            {
                string jsonData = File.ReadAllText(logFilePath);
                if (!string.IsNullOrEmpty(jsonData))
                {
                    logs = JsonConvert.DeserializeObject<List<Log>>(jsonData);
                    DateTime oneMonthAgo = DateTime.Now.AddMonths(-1);

                    logs = logs.OrderByDescending(log => log.CreatedDate).ToList();
                }
            }

            return logs;
        }

        public static void LogAction(string merchant, string username, decimal price)
        {
            string logFilePath = HttpContext.Current.Server.MapPath(Constants.LogsJson);
            List<Log> logList = GetLogs();
            
            Log newLog = new Log
            {
                Id = GenerateId(logList),
                Merchant = merchant,
                Username = username,
                Price = price,
                CreatedDate = DateTime.Now,
            };

            logList.Add(newLog);

            DateTime oneMonthAgo = DateTime.Now.AddMonths(-1);
            logList = logList.Where(log => log.CreatedDate >= oneMonthAgo).ToList();

            string updatedJson = JsonConvert.SerializeObject(logList, Formatting.Indented);
            File.WriteAllText(logFilePath, updatedJson);
        }

        private static int GenerateId(List <Log> loglist)
        {
            return loglist.Any() ? loglist.Max(log => log.Id) + 1 : 0;
        }
    }
}