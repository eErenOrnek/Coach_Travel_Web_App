using Newtonsoft.Json;
using System;

namespace CoreLayer
{
    public class JobManager
    {
        public static string CreateMessage(string title, string message, string alertType)
        {
            var msg = new AlertMessage()
            {
                Title = title,
                Message = message,
                AlertType = alertType
            };
            return JsonConvert.SerializeObject(msg);
        }
    }
}
