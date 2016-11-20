using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Song
    {
        [Display(Name ="Song ID")]
        [Required(ErrorMessage ="Missing Song ID")]
        public Int32 SongId { get; set; }

        [Display(Name = "Song Name")]
        [Required(ErrorMessage = "Missing Song Name")]
        public string SongName { get; set; }

        [Display(Name = "Song Price")]
        [Required(ErrorMessage = "Missing Song Price")]
        public decimal SongPrice { get; set; }

        //TODO: Have calculated fields like Revenue, NumSold <-- in controller
        public decimal SongRating { get; set; }

        public virtual List<SongReview> SongReviews { get; set; }

        [Display(Name = "Song Artists")]
        [Required(ErrorMessage = "Missing Song Artists List")]
        public virtual List<Artist> SongArtists { get; set; }

        [Display(Name = "Album")]
        public virtual Album SongAlbum { get; set; }

        [Display(Name = "Song Genres")]
        [Required(ErrorMessage = "Missing Song Genres List")]
        public virtual List<Genre> SongGenres { get; set; }

        public virtual List<ItemDetail> SongPurchaseDetail { get; set; }

    }
}