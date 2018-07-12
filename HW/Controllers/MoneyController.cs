using HW.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW.Controllers
{
    public class MoneyController : Controller
    {
        public ActionResult Index()
        {
           

            return View();
        }

        [ChildActionOnly]
        public ActionResult List()
        {
            List<MoneyViewModels> moneyList = new List<MoneyViewModels>();

            for (int i = 0; i < 50; i++)
            {
                MoneyViewModels money = new MoneyViewModels
                {
                    pageNo = (i + 1).ToString(),
                    date = DateTime.Now.AddDays(-i),
                    category = "支出",
                    amount = (i+1) * 100
                };

                moneyList.Add(money);
            }

            return View(moneyList);
        }
    }
}