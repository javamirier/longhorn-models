using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Review
    {
        public Int32 ReviewId { get; set; }

        public virtual List<SongReview> SongReviewsList { get; set; }
        
        public virtual List<AlbumReview> AlbumReviewsList { get; set; }
        
        public virtual List<ArtistReview> ArtistReviewsList { get; set; } 
    }
}