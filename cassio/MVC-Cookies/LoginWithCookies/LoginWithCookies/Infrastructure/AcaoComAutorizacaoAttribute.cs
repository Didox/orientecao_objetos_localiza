using Microsoft.AspNetCore.Mvc.Filters;

namespace LoginWithCookies.Controllers
{
    internal class AcaoComAutorizacaoAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (string.IsNullOrEmpty(filterContext.HttpContext.Request.Cookies["Cassio"]))
            {
                filterContext.HttpContext.Response.Redirect("/Home/Login");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}