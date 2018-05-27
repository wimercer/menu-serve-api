using Microsoft.AspNetCore.Mvc;

namespace menu_serve_api.Controllers
{
    // Route prefix for controller
    //Get: {mydomain}/api/menu/
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        //Get: {mydomain}/api/menu/
        [HttpGet]
        public JsonResult Index()
        {
            return new JsonResult("Stub for menu data");
        }

        //Get: {mydomain}/api/menu/1
        [Route("item/{id}")]
        public JsonResult Item(int id)
        {
            return new JsonResult("Menu Item " + id.ToString());
        }
    }
}