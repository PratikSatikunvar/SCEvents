using System.Web.Mvc;

namespace SC.Events.Controllers
{
    public class RemoteEventController : Controller
    {
        // GET: Global
        public ActionResult Index()
        {
            var args = new Events.RemoteEvent.RemoteEventArgs();
            args.ItemName = "SUGNCR";
            Sitecore.Eventing.EventManager.QueueEvent<Events.RemoteEvent.RemoteEventArgs>(args);
            return new EmptyResult();
        }
    }
}