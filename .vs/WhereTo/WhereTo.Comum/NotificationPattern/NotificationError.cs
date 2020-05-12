using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereTo.Comum.NotificationPattern
{
    public enum NotificationErrorType
    {
        UNKNOW = 0,
        BUSINESS_RULES = 1,
        DATABASE = 2,
        CONNECTION = 3,
        USER = 4
    }

    public class NotificationError
    {
        public string Message { get; set; }
        public NotificationErrorType Type { get; set; }

        public NotificationError(string message, NotificationErrorType type = NotificationErrorType.UNKNOW)
        {
            Message = message;
            Type = type;
        }
    }
}
