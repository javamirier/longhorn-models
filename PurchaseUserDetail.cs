﻿using System;
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
        [Display(Name ="Purchase User Detail ID")]
        public Int32 PurchaseUserDetailId { get; set; }

        [Display(Name = "Purchase Credit Card")]
        public string CreditCard { get; set; }

        [ForeignKey("PurchaseId")]
        [Display(Name = "Purchase")]
        public Purchase Purchase { get; set; }

        [ForeignKey("Id")]
        [Display(Name = "Customer")]
        public AppUser Customer { get; set; }

        public PurchaseUserDetail()
        {
            Random random = new Random();
            this.PurchaseUserDetailId = random.Next(10000000);
        }
    }
}