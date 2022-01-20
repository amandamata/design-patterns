using System;

namespace DesignPatterns.Observer.Problem
{
    public class SendMessage
    {
        public void SendSMS(Invoice invoice)
        {
            Console.WriteLine("sending message");
        }
    }
}
