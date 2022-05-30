using Microsoft.AspNetCore.Mvc;

namespace ConsulAPI.Controllers
{
    public abstract class BaseController : ControllerBase, IBaseController
    {
        public abstract ContentResult Get();
    }
}
