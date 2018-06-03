using Sitecore.Eventing;
using Sitecore.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC.Events.Events.RemoteEvent
{
    public class RemoteEventInitialization
    {
        public void Initialize(PipelineArgs args)
        {
            EventManager.Subscribe<RemoteEventArgs>(new Action<RemoteEventArgs>(RaiseRemoteEvent));
        }

        private void RaiseRemoteEvent(RemoteEventArgs remoteEvent)
        {
            Sitecore.Events.Event.RaiseEvent("item:localevent:remote",
                                             new object[] { remoteEvent });
        }
    }
}