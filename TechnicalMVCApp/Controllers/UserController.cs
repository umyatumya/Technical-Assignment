using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TechnicalMVCApp.Models;

namespace TechnicalMVCApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            IEnumerable<User> ulist;
            HttpResponseMessage response = APIConnection.APIClient.GetAsync("tbl_UserDetailsAPI").Result;
            ulist=response.Content.ReadAsAsync<IEnumerable<User>>().Result;
          
            return View(ulist);
        }


        public ActionResult Create(int id = 0)
        {
            if (id == 0)
            {
                return View(new User());
            }
            else
            {
                HttpResponseMessage response = APIConnection.APIClient.GetAsync("tbl_UserDetailsAPI/" +id.ToString()).Result;
                return View(response.Content.ReadAsAsync<User>().Result);
            }
          
        }

        [HttpPost]
        public ActionResult Create(User _user)
        {
            if (_user.userid == 0)
            {
                HttpResponseMessage response = APIConnection.APIClient.PostAsJsonAsync("tbl_UserDetailsAPI", _user).Result;
            }
            else
            {
                HttpResponseMessage response = APIConnection.APIClient.PutAsJsonAsync("tbl_UserDetailsAPI/"+_user.userid,_user).Result;
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = APIConnection.APIClient.DeleteAsync("tbl_UserDetailsAPI/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}