using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Purchase
    {
        //TODO: Add boolean value for IsGift? 
        [Display(Name="Purchase ID")]
        public  Int32 PurchaseId { get; set; }

        [Required(ErrorMessage="Date Missing")]
        [Display(Name="Purchase Date")]
        //TODO: Add string format from HW7? 
        public DateTime Date { get; set; }

        [Required(ErrorMessage="Price Missing")]
        [Display(Name="Total Purchase Price")]
        public Decimal TotalPrice { get; set; }

        [Required(ErrorMessage="Incomplete Item List")]
        [Display(Name="ItemDetails")]
        public List<ItemDetail> ItemDetails { get; set; }

        [Required(ErrorMessage="Tax Missing")]
        [Display(Name="Purchase Tax")]
        public Decimal Tax { get; set; }

        [Display(Name="Is Complete")]
        public bool IsComplete { get; set; }
        
        //TODO: Make changes to controller to accomodate PurchaseUserDetails nav property
        [Display(Name="Purchase User Details")]
        public virtual PurchaseUserDetails PurchaseUserDetails { get; set; }

        [Display(Name="Recipient")]
        public virtual AppUser Recipient { get; set; }
    }
}