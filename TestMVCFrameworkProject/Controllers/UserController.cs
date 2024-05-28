using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVCFrameworkProject.Models;

namespace TestMVCFrameworkProject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var list = UserClaim.UserList();
            return View(list);
        }

        [HttpPost]
        public JsonResult DeleteUser(int id)
        {
            try
            {
                UserClaim.Delete(id);
                return Json(new { success = true, message = "User deleted successfully" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
