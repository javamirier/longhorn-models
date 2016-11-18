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
        public Int32 AlbumId { get; set; }

        public string AlbumName { get; set; }

        public virtual List<AlbumReview> AlbumReviews { get; set; }

        public virtual List<Song> AlbumSongs { get; set; }

        public virtual List<Artist> AlbumArtists { get; set; }

        public virtual List<Genre> AlbumGenres { get; set; }
    }
}