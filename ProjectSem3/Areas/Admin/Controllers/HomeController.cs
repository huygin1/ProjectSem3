using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectSem3.Areas.Admin.Models;
using System.Net.Http;
namespace ProjectSem3.Areas.Admin.Controllers
{ 
    [Area("Admin")]
    [Route("Admin/Home")]
    public class HomeController : Controller
    {
        public string url = "http://localhost:61505/api/";
        private HttpClient httpClient = new HttpClient();
        public bool CheckLogin()
        {
            string Role = HttpContext.Session.GetString("_Role");
            if (string.IsNullOrEmpty(Role))
            {
                return false;

            }
            else
            {
                string _Role = Role.ToUpper();
                if (_Role.Equals("ADMIN"))
                {
                    return true;
                }

            }
            return false;
        }
        [Route("index")]
        public IActionResult Index()
        {
            
            if (!CheckLogin())return RedirectToAction("Login");
            return View();

        }
        [Route("Profile")]
        public IActionResult Profile()
        {
            if (!CheckLogin()) return RedirectToAction("Login");
            return View();
        }
        [Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [Route("Login")]
        [HttpPost]
        public IActionResult Login(string UserName,string PassWord)
        {
            
            var model = JsonConvert.DeserializeObject<IEnumerable<Accounts>>(httpClient.GetStringAsync(url+ "Accounts/").Result);
            Accounts accounts = model.Where(e => e.AccountName.Equals(UserName)).FirstOrDefault();
            if (accounts != null)
            {
                if (accounts.Password.Equals(PassWord))
                {
                    HttpContext.Session.SetString("_UserName", UserName);
                    HttpContext.Session.SetString("_Image", "avatar.png");
                    HttpContext.Session.SetString("_Role", accounts.Role);
                    HttpContext.Session.SetInt32("_ID",accounts.AccountID);
                    return RedirectToAction("index");
                }
                else
                {
                    ViewBag.Msg = "Password wrong!!!";
                }
                
               
            
            }
            return View();
        }
    }
}
