using System;
using System.Threading;

namespace UsingInBuildDelegateEventHandlerAndEventArgs
{
    /// <summary>
    /// PUBLISHER
    /// </summary>
    public class VideoEncoder
    {
        // We can give this class an ability to publish an event in 3 steps

        // ***** NO NEED OF THIS STEPS SINCE WE WILL USE IN BUILD DELEGATE CALLED EVENTHANDLER
        // 1. Define a delegate (contract between publisher and subscriber)
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2. Define an in build delegate based of generic type (we also have another variation without args)
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ...");
            Thread.Sleep(3000);

            // 3. Raise the event
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video });
        }
    }
}
