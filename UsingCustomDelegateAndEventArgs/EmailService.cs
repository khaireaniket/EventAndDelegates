using System;

namespace UsingCustomDelegateAndEventArgs
{
    /// <summary>
    /// SUBSCRIBER
    /// </summary>
    public class EmailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending an email ..." + args.Video.Title);
        }
    }
}
