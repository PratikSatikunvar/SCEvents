using Sitecore.Events;

namespace SC.Events.Events.LocalEvent
{
    public class LocalEventArgs: System.EventArgs, IPassNativeEventArgs
    {
        public string ItemName { get; set; }
    }
}