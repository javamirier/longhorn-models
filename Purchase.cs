﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LonghornMusic.Models
{
    public class Purchase
    {
        [Key]
        [Display(Name="Purchase ID")]
        public  Int32 PurchaseId { get; set; }
        
        [Display(Name="Purchase Date")]
        public DateTime Date { get; set; }
        
        [Display(Name="Subtotal")]
        public Decimal Subtotal { get; set; }
        
        [Display(Name="ItemDetails")]
        public List<ItemDetail> ItemDetails { get; set; }

        [Display(Name="Is Complete")]
        public bool IsComplete { get; set; }
        
        [Display(Name="Purchase User Details")]
        public virtual List<PurchaseUserDetail> PurchaseUserDetail { get; set; }

        [Display(Name="Recipient")]
        public virtual AppUser Recipient { get; set; }

        public Purchase()
        {
            this.ItemDetails = new List<Models.ItemDetail>();
            this.PurchaseUserDetail = new List<Models.PurchaseUserDetail>();
        }
    }
}