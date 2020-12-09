using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectSem3.Areas.Admin.Models;

using Microsoft.AspNetCore.Http;
using System.Net.Http;
namespace ProjectSem3.Areas.Admin.Components
{
    [ViewComponent(Name = "Accounts")]
    public class CardViewComponent : ViewComponent
    {
        public string url = "http://localhost:61505/api/Accounts";
        private HttpClient httpClient = new HttpClient();
       
       

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string _ID = HttpContext.Session.GetInt32("_ID").ToString();
            var model = JsonConvert.DeserializeObject<IEnumerable<Accounts>>(httpClient.GetStringAsync(url).Result);
           
            var acc = from s in model
                      select s;
            acc = acc.Where(a => a.AccountID.ToString().Equals(_ID));
            return View(acc);
        }

    }
}
