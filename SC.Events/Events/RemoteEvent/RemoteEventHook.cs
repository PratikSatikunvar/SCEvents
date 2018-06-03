using Sitecore.Events.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SC.Events.Events.RemoteEvent
{
    public class RemoteEventHook: IHook
    {
        public void Initialize()
        {
            Sitecore.Eventing.EventManager.Subscribe<RemoteEventArgs>(new Action<RemoteEventArgs>(RemoteEventHandler.RaiseEventLocally));
        }
    }
}