using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW.Models.ViewModels
{
    public class MoneyViewModels
    {
        /// <summary>
        /// 頁碼
        /// </summary>
        public string PageNo { get; set; }

        /// <summary>
        /// 類別
        /// </summary>
        [Display(Name="類別")]
        public string Category { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Display(Name= "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Sdate { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        [Display(Name= "金額")]
        //[DisplayFormat(DataFormatString = "{0:N0}")]
        //你已經知道 DisplayFormat 了，這裡加上去 HTML 就不用再做事情了
        public int Amount { get; set; }
    }
}