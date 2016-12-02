using System;
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
        [Display(Name="Purchase ID")]
        public  Int32 PurchaseId { get; set; }
        
        [Display(Name="Purchase Date")]
        public DateTime Date { get; set; }
        
        [Display(Name="Subtotal")]
        public Decimal Subtotal { get; set; }

        [ForeignKey("ItemDetailId")]
        [Display(Name="ItemDetails")]
        public List<ItemDetail> ItemDetails { get; set; }

        [Display(Name="Is Complete")]
        public bool IsComplete { get; set; }

        [ForeignKey("PurchaseUserDetailId")]
        [Display(Name="Purchase User Details")]
        public virtual PurchaseUserDetail PurchaseUserDetail { get; set; }

        [ForeignKey("Id")]
        [Display(Name="Recipient")]
        public virtual AppUser Recipient { get; set; }

        public Purchase()
        {
            Random random = new Random();
            this.PurchaseId = random.Next(10000000);
            this.ItemDetails = new List<Models.ItemDetail>();
        }
    }
}