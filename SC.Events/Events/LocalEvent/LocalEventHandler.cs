using Sitecore.Diagnostics;
using System;

namespace SC.Events.Events.LocalEvent
{
    public class LocalEventHandler
    {
        public void OnLocalEvent(object sender, EventArgs args)
        {
            var localEventArgs = args as LocalEventArgs;
            Log.Info($"Local event raised: {localEventArgs.ItemName}", nameof(LocalEventHandler));
        }
    }
}