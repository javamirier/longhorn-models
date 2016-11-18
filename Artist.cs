using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Artist
    {
        public Int32 ArtistId { get; set; }

        [Display(Name = "Artist Name")]
        [Required(ErrorMessage="Arist Name is required.")]
        public string ArtistName { get; set; }

        //public Int32 ArtistRevenue { get; set; }
        //public Int32 ArtistSales { get; set; }

        [Display(Name = "Artist Genres")]
        public List<Genre> ArtistGenres { get; set; }

        [Display(Name = "Artist Rating")]
        public Int32 ArtistRating { get; set; }

        public virtual List<ArtistReview> ArtistReviews { get; set; }

        public virtual List<Album> ArtistAlbums { get; set; }

        public virtual List<Song> ArtistSongs { get; set; }
    }
}