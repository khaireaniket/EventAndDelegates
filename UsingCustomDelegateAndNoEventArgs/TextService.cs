using System;

namespace UsingCustomDelegateAndNoEventArgs
{
    /// <summary>
    /// SUBSCRIBER
    /// </summary>
    public class TextService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending a text message ...");
        }
    }
}
