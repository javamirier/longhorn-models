using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class ArtistReview
    {
        public Int32 ArtistReviewId { get; set; }

        [Required(ErrorMessage="Please select a score.")]
        [Display(Name = "Score")]
        public Int32 ArtistScore { get; set; }

        [Display(Name = "Review Text (optional)")]
        public string ArtistReviewText { get; set; }

        [Display(Name = "Review Author")]
        public virtual Customer ArtistReviewAuthor { get; set; }

        [Display(Name = "Artist")]
        public virtual Artist ReviewedArtist { get; set; }
    }
}