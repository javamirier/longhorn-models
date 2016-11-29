using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Artist
    {
        //TODO: Fix the fucking models 
        [Required(ErrorMessage = "Missing Artist ID")]
        [Display(Name = "Artist ID")]
        public Int32 ArtistId { get; set; }

        [Display(Name = "Artist Name")]
        [Required(ErrorMessage="Arist Name is required.")]
        public string ArtistName { get; set; }

        //public Int32 ArtistRevenue { get; set; }
        //public Int32 ArtistSales { get; set; }

        [Display(Name = "Artist Genres")]
        [Required(ErrorMessage ="Missing Artist Genre(s)")]
        public List<Genre> ArtistGenres { get; set; }

        [Display(Name = "Artist Rating")]
        public decimal ArtistRating { get; set; }

        public virtual List<ArtistReview> ArtistReviews { get; set; }

        public virtual List<Album> ArtistAlbums { get; set; }
        
        public virtual List<Song> ArtistSongs { get; set; }

        //TODO: Jesus take the keyboard im typin blind https://piazza.com/class/iry0whqtflz28x?cid=437
        public Artist()
        {
            this.ArtistReviews = new List<Models.ArtistReview>();
            this.ArtistAlbums = new List<Models.Album>();
            this.ArtistSongs = new List<Models.Song>();
            this.ArtistGenres = new List<Models.Genre>();
        }
    }
}