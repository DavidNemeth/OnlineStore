using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "easyridertest@gmail.com";
        public string MailFromAddress = "easyridertest@gmail.com";
        public bool UseSsl = true;
        public string Username = "easyridertest@gmail.com";
        public string Password = "easyridertest123";//test email
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}
