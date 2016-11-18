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
        [Display(Name="Purchase ID")]
        public  Int32 PurchaseId { get; set; }

        [Required(ErrorMessage="Date Missing")]
        [Display(Name="Purchase Date")]
        //Might want to add the string format line from HW7
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

        [Display(Name="Purchaser")]
        public virtual Customer Purchaser { get; set; }

        [Display(Name="Recipient")]
        public virtual Customer Recipient { get; set; }
    }
}