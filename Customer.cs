using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Customer : AppUser
    {
        [Required(ErrorMessage = "Missing Customer ID")]
        [Display(Name = "Customer ID")]
        public Int32 CustomerId { get; set; }

        [Required(ErrorMessage = "Missing Credit Card List")]
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