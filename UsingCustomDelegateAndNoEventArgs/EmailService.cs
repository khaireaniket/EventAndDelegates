using System;

namespace UsingCustomDelegateAndNoEventArgs
{
    /// <summary>
    /// SUBSCRIBER
    /// </summary>
    public class EmailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending an email ...");
        }
    }
}
