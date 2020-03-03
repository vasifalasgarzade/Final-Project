using Meverex.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meverex.Areas.Admin.Filters
{
    public class AdminAuth : ActionFilterAttribute
    {
        private readonly FinalDbMeverex _context;

        public AdminAuth()
        {
            _context = new FinalDbMeverex();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies.Get("token");

            if (cookie == null)
            {
                filterContext.Result = new RedirectResult("~/admin/login/index");
                return;
            }

            var admin = _context.Admins.FirstOrDefault(a => a.Token == cookie.Value);

            if (admin == null)
            {
                filterContext.Result = new RedirectResult("~/admin/login/index");
                return;
            }

            filterContext.Controller.ViewBag.Admin = admin;

            base.OnActionExecuting(filterContext);
        }
    }
}