using System;

namespace UsingInBuildDelegateEventHandlerAndEventArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();
            var emailService = new EmailService();
            var textService = new TextService();

            // Subscriber
            videoEncoder.VideoEncoded += emailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;

            // Publisher
            videoEncoder.Encode(video);

            Console.WriteLine("\nPress any key to exit ...");
            Console.ReadLine();
        }
    }
}
