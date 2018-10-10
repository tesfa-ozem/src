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
using Newtonsoft.Json;

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
            InventoryContext context = new InventoryContext();
            var payments = context.Payments.Select(p => new {p.PaymentName,p.AccountNo, p.Amount, p.Id, p.PaymentDate, p.PhoneNo, p.TransactionDate,p.DocumentNo}).Take(100000).OrderByDescending(e => e.Id);
            string json = null;
            json = JsonConvert.SerializeObject(payments);
            return View("Payments", json);
        }
        public IActionResult Registration()
        {
            var xxx = _contextFactory.Invoke().People.Select(p => new { p.IdentificationNo, p.FirstName, p.LastName, p.Id, p.IdentificationType, p.MemberNo, p.PhoneNumber, p.MemberType }).Take(10000).OrderByDescending(e => e.Id);

            string json = null;// = Newtonsoft.Json.JsonConvert.SerializeObject(_repository.Peoples.Select(p=>new { p.IdentificationNo,p.FirstName,p.MiddleName })).ToList());
            json = JsonConvert.SerializeObject(xxx);
            return View("Registration", json);
        }

        public IActionResult Edit(int id)
        {
            var agent = _contextFactory.Invoke().People.Where(s => s.Id == id).FirstOrDefault();
            return View("Edit", agent);
        }

        [HttpPost]
        public IActionResult Post(People test)
        {
            try
            {
                InventoryContext context = new InventoryContext();
                if (test != null)
                {
                    bool isNew = false;
                    var data = context.People.Where(p => p.Id == test.Id).FirstOrDefault();
                    if (data == null)
                    {
                        data = new People();
                        isNew = true;
                    }
                    data.FirstName = test.FirstName;
                    data.LastName = test.LastName;
                    data.IdentificationNo = test.IdentificationNo;
                    data.PhoneNumber = test.PhoneNumber;
                    data.MemberType = test.MemberType;



                    context.People.UpdateRange(data);

                    context.SaveChanges();
                }
                return RedirectToAction("Registration");
            }
            catch (Exception r)
            {
                return NotFound(r.Message);
            }
        }

        public IActionResult EditPayment(int id)
        {
            var Transaction = _contextFactory.Invoke().Payments.Where(s => s.Id == id).FirstOrDefault();
            return View("EditPayments", Transaction);
        }

        [HttpPost]
        public IActionResult PostPayment(Payments test)
        {
            try
            {
                InventoryContext context = new InventoryContext();
                if (test != null)
                {
                    bool isNew = false;
                    var data = context.Payments.Where(p => p.Id == test.Id).FirstOrDefault();
                    if (data == null)
                    {
                        data = new Payments();
                        isNew = true;
                    }
                    data.AccountNo = test.AccountNo;




                    context.Payments.UpdateRange(data);

                    context.SaveChanges();
                }
                return RedirectToAction("Payments");
            }
            catch (Exception r)
            {
                return NotFound(r.Message);
            }
        }

        public IActionResult MakePayments()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult CreatePayment(Payments transaction)
        {
            try
            {
                InventoryContext context = new InventoryContext();
                var Transaction = new Payments()
                {
                    AccountNo = transaction.AccountNo,
                    PhoneNo = transaction.PhoneNo,
                    Amount = transaction.Amount,
                    TransactionDate = transaction.TransactionDate,
                    PaymentDate = transaction.TransactionDate,
                    DateModified = transaction.TransactionDate,
                    DocumentNo = transaction.DocumentNo,
                    Status = transaction.Status,
                    PaymentMode = "Manual",
                    PaymentName = transaction.PaymentName
                };
                context.Payments.Add(Transaction);
                context.SaveChanges();

                return RedirectToAction("Payments");
            }
            catch (Exception e)
            {
                return NoContent();
            }
        }

    }
}
