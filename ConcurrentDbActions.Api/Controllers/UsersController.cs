using ConcurrentDbActions.Domain.Constants;
using Microsoft.AspNetCore.Mvc;

namespace ConcurrentDbActions.Api.Controllers
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route(Routes.DefaultVersionedApiRoute)]
    public class UsersController : BaseController
    {
        [HttpGet]
        public string Get() => "Remo";
    }
}
