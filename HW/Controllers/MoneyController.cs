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
        public ActionResult _List()
        {
            List<MoneyViewModels> moneyList = new List<MoneyViewModels>();

            for (int i = 0; i < 50; i++)
            {
                MoneyViewModels money = new MoneyViewModels
                {
                    PageNo = (i + 1).ToString(),
                    Sdate = DateTime.Now.AddDays(-i),
                    Category = "支出",
                    Amount = (i+1) * 100
                };

                moneyList.Add(money);
            }

            return View(moneyList);
        }
    }
}