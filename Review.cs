﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Review
    {
        //TODO: Fix the bridge classes 
        public Int32 ReviewId { get; set; }

        public AppUser Author { get; set; }

        public virtual List<SongReview> SongReviewsList { get; set; }
        
        public virtual List<AlbumReview> AlbumReviewsList { get; set; }
        
        public virtual List<ArtistReview> ArtistReviewsList { get; set; } 

        public Review()
        {
            this.SongReviewsList = new List<Models.SongReview>();
            this.AlbumReviewsList = new List<Models.AlbumReview>();
            this.ArtistReviewsList = new List<Models.ArtistReview>();
        }
    }
}