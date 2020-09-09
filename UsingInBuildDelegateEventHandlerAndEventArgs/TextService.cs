using System;

namespace UsingInBuildDelegateEventHandlerAndEventArgs
{
    /// <summary>
    /// SUBSCRIBER
    /// </summary>
    public class TextService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Sending a text message ..." + args.Video.Title);
        }
    }
}
