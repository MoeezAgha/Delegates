using System;
using System.Threading;

namespace Delegates
{
    public class VideoEncoder
    {

        //Define the delegate
        //Define an event 
        //Raise event 


        public delegate void VideoEncoderEventHandler(object Source, VideoEventArgs eventArgs);//Name of Delegate

        //EventHandler
        //EventHandler<TeventArgs>
        //public event VideoEncoderEventHandler VideoEncodedEvent;//Event name

        public event EventHandler<VideoEventArgs> VideoEncodedEvent;

        public void Encode(VideoEventArgs video)
        {

            Console.WriteLine("SomeAction Start......");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }


        protected virtual void OnVideoEncoded()
        {

            if (VideoEncodedEvent != null)
            {
                VideoEncodedEvent(this, new VideoEventArgs() { Name = "This Message from OnVideoEncoded" }); ;
            }

        }

    }
}
