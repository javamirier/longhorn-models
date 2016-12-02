using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LonghornMusic.Models
{
    public class PurchaseUserDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Purchase User Detail ID")]
        [Required(ErrorMessage ="Missing PUD ID")]
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