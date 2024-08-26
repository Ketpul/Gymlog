using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gymlog.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
