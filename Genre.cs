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
        public Int32 GenreId { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public string GenreName { get; set; }

        public virtual List<Song> Songs { get; set; }

        public virtual List<Album> Albums { get; set; }

        public virtual List<Artist> Artists { get; set; }
    }
}