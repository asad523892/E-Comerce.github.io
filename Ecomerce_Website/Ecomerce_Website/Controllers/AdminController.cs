using Ecomerce_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerce_Website.Controllers
{
    public class AdminController : Controller
    {
        private Mycontext _mycontext;
        public AdminController(Mycontext context)
        {
            _mycontext = context;
        }
        public IActionResult Index()
        {
          string admin =  HttpContext.Session.GetString("admin_seassion");
            if (admin != null)
            {
                return View();
            }
            else
            {
               return RedirectToAction("login");
            }
            
        }


        public IActionResult login()
        {
           

            return View();
        }

        [HttpPost]
        public IActionResult login(string adminEmail , string adminpassword)
        {
           var row= _mycontext.tbl_admin.FirstOrDefault(a=>a.admin_email == adminEmail);
            if (row != null && row.admin_password==adminpassword) 
            {
                HttpContext.Session.SetString("admin_seassion",row.admin_id.ToString());

                return RedirectToAction("Index");
            }

            else 
            {
               TempData["message"]="Incorrect Username or password";
                    return View();
            }
            
        }
        public IActionResult logout()
        {

            HttpContext.Session.Remove("admin_seassion");
            return RedirectToAction("login");
        }

        public IActionResult Profile()
        {
            string admin = HttpContext.Session.GetString("admin_seassion");
            if (admin != null)
            {
               var row= _mycontext.tbl_admin.Where(a=>a.admin_id==int.Parse(admin)).ToList();
                return View(row);
            }
            else
            {
                return RedirectToAction("login");
            }

            
           
        }

    }
}
