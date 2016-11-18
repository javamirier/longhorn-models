using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Promotion
    {
        [Display(Name="Promotion ID")]
        public Int32 PromotionId { get; set; }

        [Display(Name="Dicsount Percentage")]
        public Decimal DiscountPercentage { get; set; }

        [Display(Name="Promotional Item")]
        public virtual ItemDetail Item { get; set; }

        [Display(Name="Is Active")]
        public bool IsActive { get; set; }

        [Display(Name="Is Featured")]
        public bool ISFeatured { get; set; }
    }
}