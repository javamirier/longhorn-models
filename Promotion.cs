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

        [Display(Name="Promotional Songs")]
        public virtual List<Song> DiscountedSongs { get; set; }

        [Display(Name = "Promotional Albums")]
        public virtual List<Album> DiscountedAlbums { get; set; }

        [Display(Name="Is Active")]
        public bool IsActive { get; set; }

        [Display(Name="Is Featured")]
        public bool IsFeatured { get; set; }

        public Promotion()
        {
            this.DiscountedSongs = new List<Models.Song>();
            this.DiscountedAlbums = new List<Models.Album>();
        }
    }
}