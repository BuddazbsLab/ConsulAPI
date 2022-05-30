using Microsoft.AspNetCore.Mvc;

namespace ConsulAPI.Controllers
{
    public interface IBaseController
    {
        ContentResult Get();
    }
}