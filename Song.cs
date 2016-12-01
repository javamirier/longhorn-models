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

        public string SongArtistString { get { return getArtistString(); } }

        public string SongAlbumString { get { return getAlbumString(); } }

        [Display(Name = "Album")]
        public virtual List<Album> SongAlbums { get; set; }

        [Display(Name = "Song Genres")]
        [Required(ErrorMessage = "Missing Song Genres List")]
        public virtual List<Genre> SongGenres { get; set; }

        public virtual List<ItemDetail> SongPurchaseDetails { get; set; }

        //TODO: Jesus take the keyboard im typin blind 
        public Song()
        {
            this.SongReviews = new List<Models.SongReview>();
            this.SongArtists = new List<Models.Artist>();
            this.SongAlbums = new List<Models.Album>();
            this.SongGenres = new List<Models.Genre>();
            this.SongPurchaseDetails = new List<Models.ItemDetail>();
        }


        public string getArtistString()
        {
            string ArtistString;
            if (this.SongArtists == null || this.SongArtists.Count == 0)
            {
                return "No Artist";
            }
            if (this.SongArtists.Count == 1) 
            {
                ArtistString = SongArtists.ElementAt(0).ArtistName;
                return ArtistString;
            }

            if (SongArtists.Count == 2)
            {
                ArtistString = SongArtists.ElementAt(0).ArtistName + " ft. " + SongArtists.ElementAt(1).ArtistName;
                return ArtistString;
            }
            if (SongArtists.Count == 3)
            {
                ArtistString = SongArtists.ElementAt(0).ArtistName + " ft. " + SongArtists.ElementAt(1).ArtistName + ", " + SongArtists.ElementAt(2).ArtistName;

                return ArtistString;
            }

            else
            {
                string tempstring = SongArtists.ElementAt(0).ArtistName;

                tempstring = tempstring + " ft. " + SongArtists.ElementAt(1).ArtistName;

                List<Artist> temp = new List<Artist>();

                temp.Add(SongArtists.ElementAt(0));
                temp.Add(SongArtists.ElementAt(1));

                foreach (Artist ArtistName in SongArtists)
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

        public string getAlbumString()
        {
            if (this.SongArtists == null || this.SongArtists.Count == 0)
            {
                return "No Album";
            }
            else
            {
                string tempstring = "";
                foreach (Album Album in SongAlbums)
                {
                    tempstring = tempstring + Album.AlbumName + ": ";
                }
                return tempstring;
            }
            

        }


    }
}