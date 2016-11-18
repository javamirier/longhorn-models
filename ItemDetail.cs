using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace LonghornMusic.Models
{
    public class ItemDetail
    {
        [Display(Name="Item Detail Id")]
        public Int32 ItemDetailId { get; set; }

        [Display(Name="Purchase Price")]
        public Decimal PurchasePrice { get; set; }

        [Display(Name="Song")]
        public virtual Song Song { get; set; }

        [Display(Name="Album")]
        public virtual Album Album { get; set; }
    }
}