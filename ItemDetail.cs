﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace LonghornMusic.Models
{
    public class ItemDetail
    {
        [Display(Name="Item Detail Id")]
        public Int32 IDID { get; set; }

        [Display(Name="Purchase Price")]
        public Decimal PurchasePrice { get; set; }

        public Purchase Purchase { get; set; }

        [Display(Name="Song")]
        public virtual Song Song { get; set; }

        [Display(Name="Album")]
        public virtual Album Album { get; set; }

        public ItemDetail()
        {
            Random random = new Random();
            this.IDID = random.Next(10000000);
        }
    }
}