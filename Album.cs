using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Album
    {
        [Required(ErrorMessage ="Missing Album ID")]
        [Display(Name ="Album ID")]
        public Int32 AlbumId { get; set; }

        [Required(ErrorMessage = "Missing Album Name")]
        [Display(Name ="Album Name")]
        public string AlbumName { get; set; }

        [Display(Name = "Album Price")]
        [Required(ErrorMessage = "Missing Album Price")]
        public decimal AlbumPrice { get; set; }

        [Display(Name ="Album Reviews")]
        public virtual List<AlbumReview> AlbumReviews { get; set; }

        [Required(ErrorMessage = "Missing Album Song List")]
        [Display(Name ="Album Songs")]
        public virtual List<Song> AlbumSongs { get; set; }

        [Required(ErrorMessage = "Missing Album Artist List")]
        [Display(Name ="Album Artists")]
        public virtual List<Artist> AlbumArtists { get; set; }

        [Required(ErrorMessage = "Missing Album Genre List")]
        [Display(Name ="Album Genres")]
        public virtual List<Genre> AlbumGenres { get; set; }

        public virtual List<ItemDetail> AlbumPurchaseDetails { get; set; }
    }
}