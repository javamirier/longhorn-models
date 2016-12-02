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
        [Required(ErrorMessage = "Missing Album ID")]
        [Display(Name = "Album ID")]
        public Int32 AlbumId { get; set; }

        [Required(ErrorMessage = "Missing Album Name")]
        [Display(Name = "Album Name")]
        public string AlbumName { get; set; }

        [Display(Name = "Album Price")]
        [Required(ErrorMessage = "Missing Album Price")]
        public decimal AlbumPrice { get; set; }

        [Display(Name = "Album Reviews")]
        public virtual List<AlbumReview> AlbumReviews { get; set; }

        public decimal AlbumRating { get; set; }

        public string AlbumArtistString { get { return getArtistString(); } }

        [Required(ErrorMessage = "Missing Album Song List")]
        [Display(Name = "Album Songs")]
        public virtual List<Song> AlbumSongs { get; set; }

        [Required(ErrorMessage = "Missing Album Artist List")]
        [Display(Name = "Album Artists")]
        public virtual List<Artist> AlbumArtists { get; set; }

        [Required(ErrorMessage = "Missing Album Genre List")]
        [Display(Name = "Album Genres")]
        public virtual List<Genre> AlbumGenres { get; set; }

        public virtual List<ItemDetail> AlbumPurchaseDetails { get; set; }

        public Album()
        {
            this.AlbumReviews = new List<Models.AlbumReview>();
            this.AlbumArtists = new List<Models.Artist>();
            this.AlbumSongs = new List<Models.Song>();
            this.AlbumGenres = new List<Models.Genre>();
            this.AlbumPurchaseDetails = new List<Models.ItemDetail>();
        }

        public string getArtistString()
        {
            string ArtistString;
            if (this.AlbumArtists == null || this.AlbumArtists.Count == 0)
            {
                return "No Artist";
            }
            if (this.AlbumArtists.Count == 1)
            {
                ArtistString = AlbumArtists.ElementAt(0).ArtistName;
                return ArtistString;
            }

            if (AlbumArtists.Count == 2)
            {
                ArtistString = AlbumArtists.ElementAt(0).ArtistName + " ft. " + AlbumArtists.ElementAt(1).ArtistName;
                return ArtistString;
            }
            if (AlbumArtists.Count == 3)
            {
                ArtistString = AlbumArtists.ElementAt(0).ArtistName + " ft. " + AlbumArtists.ElementAt(1).ArtistName + ", " + AlbumArtists.ElementAt(2).ArtistName;

                return ArtistString;
            }

            else
            {
                string tempstring = AlbumArtists.ElementAt(0).ArtistName;

                tempstring = tempstring + " ft. " + AlbumArtists.ElementAt(1).ArtistName;

                List<Artist> temp = new List<Artist>();

                temp.Add(AlbumArtists.ElementAt(0));
                temp.Add(AlbumArtists.ElementAt(1));

                foreach (Artist ArtistName in AlbumArtists)
                {

                    if (temp.Contains(ArtistName))
                    {

                    }
                    else
                    {
                        tempstring = tempstring + ", " + ArtistName.ArtistName;
                    }

                }

                ArtistString = tempstring;

                return ArtistString;
            }

        }
    }
}