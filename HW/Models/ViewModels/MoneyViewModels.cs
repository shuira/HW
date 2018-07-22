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
        public string pageNo { get; set; }

        /// <summary>
        /// 類別
        /// </summary>

        [Display(Name = "類別")]
        public string category { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Display(Name = "日期")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime date { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "輸入金額太大")]
        [Display(Name = "金額")]
        public int amount { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        [Required(ErrorMessage = "test")]
        [StringLength(200)]
        [Display(Name = "備註")]
        public string remark { get; set; }
    }
}