using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TinySocial.API.Controllers
{

    [Authorize]
    public class TestController : BaseAPIController
    {
        [HttpGet]
        public ActionResult<string> Test()
        {
            return "Tested Succesfully";
        }
    }
}
