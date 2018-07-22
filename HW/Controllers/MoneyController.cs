using HW.Models.ViewModels;
using HW.Repository;
using HW.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW.Models;

namespace HW.Controllers
{
    public class MoneyController : Controller
    {
        private readonly HWService _hwService;
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// 建構子注入
        /// </summary>
        public MoneyController()
        {
            _unitOfWork = new UnitOfWork();
            _hwService = new HWService(_unitOfWork);
        }

        public ActionResult Index()
        {
            ViewBag.category = _hwService.GetCategoryItems();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(MoneyViewModels model)
        {
            if (ModelState.IsValid)
            {
                _hwService.Add(model);

                _unitOfWork.Commit();

                return RedirectToAction("Index");
            }
            return View();
        }

        [ChildActionOnly]
        public ActionResult List()
        {
            List<MoneyViewModels> moneyList = new List<MoneyViewModels>();

            // 第一次作業假資料
            //for (int i = 0; i < 50; i++)
            //{
            //    MoneyViewModels money = new MoneyViewModels
            //    {
            //        pageNo = (i + 1).ToString(),
            //        date = DateTime.Now.AddDays(-i),
            //        category = "支出",
            //        amount = (i+1) * 100
            //    };

            //    moneyList.Add(money);
            //}
            IEnumerable<AccountBook> accbook = _hwService.Lookup();

            int i = 0;

            var data = from m in accbook
                       select new MoneyViewModels
                       {
                           pageNo = (++i).ToString(),
                           amount = m.Amounttt,
                           category = m.Categoryyy == 0 ? "支出" : "收入",
                           date = m.Dateee
                       };

            return View(data);
        }
    }
}