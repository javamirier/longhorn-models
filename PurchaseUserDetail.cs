using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class PurchaseUserDetail
    {
        [Display(Name ="Purchase Credit Card ID")]
        [Required(ErrorMessage ="Missing PCC ID")]
        public Int32 PurchaseUserDetailId { get; set; }

        [Display(Name = "Purchase Credit Card")]
        [Required(ErrorMessage = "Missing PCC")]
        public string CreditCard { get; set; }

        [Display(Name = "Purchase")]
        [Required(ErrorMessage = "Missing Purchase")]
        public Purchase Purchase { get; set; }

        [Display(Name = "Customer")]
        [Required(ErrorMessage = "Missing Customer")]
        public AppUser Customer { get; set; }
    }
}