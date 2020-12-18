using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;


namespace DataServices.WebApi.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
    }
}
