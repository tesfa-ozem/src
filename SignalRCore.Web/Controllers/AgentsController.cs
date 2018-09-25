using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.SignalR;


using Microsoft.AspNetCore.Http;

using System.IO;
using SignalRCore.Web.Models;
using SignalRCore.Web.Repository;
using SignalRCore.Web.Persistence;

namespace Accounts.Controllers
{
    public class AgentsController : Controller
    {
        public Func<InventoryContext> _contextFactory;



        
        private readonly IInventoryRepository _repository;

        public AgentsController(IInventoryRepository repository, Func<InventoryContext> context)
        {
            _repository = repository;
            _contextFactory = context;
        }


        public IActionResult Index()
        {
            

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult ValidateLogin(Login login)
        {

            if (login.UserName == "Admin" & login.Password == "kitui@254")
            {
                return RedirectToAction(actionName: nameof(Dashboard));
            }

            return View("Login");
        }
        public IActionResult Dashboard()
        {


            return View("Dashboard");
        }
        public IActionResult Payments()
        {

            return View();
        }
        public  IActionResult Registration()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(_repository.Peoples);

            return View("Registration", json);
        }

        public IActionResult Edit(int id)
        {
            var agent = _repository.Peoples.Where(s => s.Id == id).FirstOrDefault();
            return View("Edit",agent);
        }

        [HttpPost]
        public IActionResult Post(AppUsers test)
        {
            if (test != null)
            {
                bool isNew = false;
                var data = _repository.Peoples.Where(p => p.Id == test.Id).FirstOrDefault();
                if (data == null)
                {
                    data = new People();
                    isNew = true;
                }
                data.FirstName = test.FirstName;
                data.FirstName = test.LastName;
                
                
                   _contextFactory.Invoke().Add(data);
                
                _contextFactory.Invoke().SaveChanges();
            }
            return RedirectToAction("Registration");
        }



    }
}
