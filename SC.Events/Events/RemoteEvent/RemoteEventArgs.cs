using Sitecore.Events;

namespace SC.Events.Events.RemoteEvent
{
    public class RemoteEventArgs: System.EventArgs, IPassNativeEventArgs
    {
        public string ItemName { get; set; }
    }
}