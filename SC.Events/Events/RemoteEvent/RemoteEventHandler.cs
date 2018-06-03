using Sitecore.Diagnostics;
using Sitecore.Eventing;
using Sitecore.Pipelines;
using Sitecore.SecurityModel;
using System;

namespace SC.Events.Events.RemoteEvent
{
    public class RemoteEventHandler
    {
        public void OnRemoteEvent(object sender, EventArgs args)
        {
            var remoteEventArgs = args as RemoteEventArgs;
            Log.Info($"Remote event raised: {remoteEventArgs.ItemName}", nameof(RemoteEventHandler));
            using (new SecurityDisabler())
            {
                Sitecore.Data.Database masterDB = Sitecore.Configuration.Factory.GetDatabase("master");
                Sitecore.Data.Items.Item home = masterDB.GetItem("/sitecore/content/home");
                Sitecore.Data.Items.TemplateItem sample = masterDB.Templates[new Sitecore.Data.ID("{76036F5E-CBCE-46D1-AF0A-4143F9B557AA}")];
                Sitecore.Data.Items.Item myItem = home.Add(remoteEventArgs.ItemName, sample);
            }
        }

        /// <summary>
        /// This methos is used to raise the local event
        /// </summary>
        /// <param name="event"></param>
        public static void RaiseEventLocally(RemoteEventArgs @event)
        {
            Log.Info($"Remote event raised: {@event.ItemName}", nameof(RemoteEventHandler));
            RemoteEventArgs args = new RemoteEventArgs() { ItemName = @event.ItemName };
            Sitecore.Events.Event.RaiseEvent("item:localevent:remote", new object[] { args });
        }
    }
}