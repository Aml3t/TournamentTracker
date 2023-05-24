using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace TrackerLibrary
{
    public class SMSLogic
    {
        public static void SendSMSMessage(string to, string message)
        {
            string accountSid = "";
            string authToken = "";
            TwilioClient.Init(accountSid, authToken);
        }
    }
}
