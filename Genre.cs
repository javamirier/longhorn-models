using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Genre
    {
        [Required(ErrorMessage = "Missing Genre ID")]
        [Display(Name = "Genre ID")]
        public Int32 GenreId { get; set; }

        [Required(ErrorMessage ="Missing Genre Name")]
        [Display(Name = "Genre")]
        public string GenreName { get; set; }
        
        [Display(Name = "Genre Songs")]
        public virtual List<Song> Songs { get; set; }
        
        [Display(Name = "Genre Albums")]
        public virtual List<Album> Albums { get; set; }
        
        [Display(Name = "Genre Artists")]
        public virtual List<Artist> Artists { get; set; }

        public Genre()
        {
            this.Songs = new List<Models.Song>();
            this.Albums = new List<Models.Album>();
            this.Artists = new List<Models.Artist>();
        }
    }
}