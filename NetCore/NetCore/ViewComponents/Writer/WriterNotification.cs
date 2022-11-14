using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NetCore.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {

        NotificationManager Nm = new NotificationManager(new EfNotificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = Nm.GetList();
            return View(values);
        }
    }
}
