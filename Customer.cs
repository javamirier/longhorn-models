using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Customer : AppUser
    {
        public Int32 CustomerId { get; set; }

        [Display(Name = "Credit Cards")]
        public List<string> CreditCards { get; set; }

        [Display(Name = "Your Reviews")]
        public virtual List<Review> CustomerReviews { get; set; }

        [Display(Name = "Your Music Collection")]
        public virtual List<Song> MusicOwned { get; set; }

        [Display(Name = "Order History")]
        public virtual List<Purchase> OrderHistory { get; set; }
    }
}