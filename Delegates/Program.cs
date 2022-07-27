using System;

namespace Delegates
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var video = new VideoEventArgs() { Name = "Video 1" };
            var videoEncoder = new VideoEncoder();
            var mailService = new MailService();
            var textService = new TextService();
            videoEncoder.VideoEncodedEvent += mailService.OnVideoEncoded;
            videoEncoder.VideoEncodedEvent += textService.OnVideoEncoded;

            var MailService2 = new MailService2();

            videoEncoder.Encode(video);
        }


    }
    public class MailService
    {

        public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
        {

            Console.WriteLine("MailService :Send a text:" + eventArgs.Name);

        }

    }

    public class MailService2
    {

        public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
        {

            Console.WriteLine("MailService2 :Send a text:" + eventArgs.Name);

        }

    }
    public class TextService
    {

        public void OnVideoEncoded(object source, VideoEventArgs eventArgs)
        {

            Console.WriteLine("TextService :Send a text:" + eventArgs.Name);
        }

    }


    public class VideoEventArgs : EventArgs
    {
        public int UserId { get; set; }
        public string Name { get; set; }

    }
}
