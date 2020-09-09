using System;
using System.Threading;

namespace UsingCustomDelegateAndNoEventArgs
{
    /// <summary>
    /// PUBLISHER
    /// </summary>
    public class VideoEncoder
    {
        // We can give this class an ability to publish an event in 3 steps

        // 1. Define a delegate (contract between publisher and subscriber)
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // 2. Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);

            // 3. Raise the event
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            VideoEncoded?.Invoke(this, EventArgs.Empty);
        }
    }
}
