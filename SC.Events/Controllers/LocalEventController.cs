using System.Web.Mvc;

namespace SC.Events.Controllers
{
    public class LocalEventController : Controller
    {
        // GET: LocalEvent
        public ActionResult Index()
        {
            var args = new Events.LocalEvent.LocalEventArgs();
            args.ItemName = "SUGNCR";
            Sitecore.Events.Event.RaiseEvent("item:localevent", args);
            return new EmptyResult();
        }
    }
}