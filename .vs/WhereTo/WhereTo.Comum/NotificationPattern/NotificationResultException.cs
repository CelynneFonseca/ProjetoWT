using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereTo.Comum.NotificationPattern
{
    public class NotificationResultException
    {
        private readonly Exception ex;

        public NotificationResultException(Exception ex)
        {
            this.ex = ex;
        }

        private string PreMessage { get; set; }

        private string MessageError
        {
            get
            {
                string str = "";
                if (!string.IsNullOrEmpty(PreMessage))
                    str = PreMessage + ":";

                str += ex.InnerException != null ? ex.InnerException.Message : ex.Message;

                return str;
            }
        }

        public NotificationResult Result => new NotificationResult().Add(new NotificationResult().Add(MessageError));
    }
}
