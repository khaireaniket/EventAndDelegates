using System;

namespace UsingCustomDelegateAndEventArgs
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
