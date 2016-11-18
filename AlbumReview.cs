using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class AlbumReview
    {
        public Int32 AlbumReviewId { get; set; }

        [Required(ErrorMessage = "Please select a score.")]
        [Display(Name = "Score")]
        public Int32 AlbumScore { get; set; }

        [Display(Name = "Review Text (optional)")]
        public string AlbumReviewText { get; set; }

        [Display(Name = "Review Author")]
        public virtual Customer AlbumReviewAuthor { get; set; }

        [Display(Name = "Album")]
        public virtual Artist ReviewedAlbum { get; set; }
    }
}