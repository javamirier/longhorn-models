using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class SongReview
    {
        //TODO: Fix this class 
        public Int32 SongReviewId { get; set; }

        [Required(ErrorMessage = "Please select a score.")]
        [Display(Name = "Score")]
        public Int32 SongScore { get; set; }

        [Display(Name = "Review Text (optional)")]
        public string SongReviewText { get; set; }

        [Display(Name = "Review")]
        public virtual Review Review { get; set; }

        [Display(Name = "Song")]
        public virtual Song ReviewedSong { get; set; }
    }
}