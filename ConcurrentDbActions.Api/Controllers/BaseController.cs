using Microsoft.AspNetCore.Mvc;

namespace ConcurrentDbActions.Api.Controllers
{
    public class BaseController : Controller
    {
        [HttpGet]
        public virtual string GetLatestApiVersion() => HttpContext.GetRequestedApiVersion().ToString();
    }
}
