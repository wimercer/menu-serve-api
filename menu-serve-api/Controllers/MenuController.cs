using Microsoft.AspNetCore.Mvc;
using menu_serve_api.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace menu_serve_api.Controllers
{
    // Route prefix for controller
    //Get: {mydomain}/api/menu/
    [ApiController]
    [Route("api/[controller]")]
    public class MenuController : Controller
    {
        private MenuServeDBContext menuServeDBContext;

        public MenuController(MenuServeDBContext dBcontext)
        {
            menuServeDBContext = dBcontext;
        }

        // Get: {mydomain}/api/menu/
        [HttpGet]
        public JsonResult Index()
        {
            //return new JsonResult(menuServeDBContext.MenuItems
            //                                            .Include(c => c.MenuCategory)
            //                                            );
            return new JsonResult("Yup... app working, it's responding with some json");
        }

        // Get: {mydomain}/api/menu/1
        [HttpGet]
        [Route("item/{id}")]
        public JsonResult Item(int id)
        {


            if (menuServeDBContext.Database.EnsureCreated())
            {
                return new JsonResult("Number " + id + "!");
            }
            else
            {
                return new JsonResult(menuServeDBContext.MenuItems
                                                        .Include(c => c.MenuCategory)
                                                        .Where(i => i.ID == id)
                                                        );
            }
        }
    }
}