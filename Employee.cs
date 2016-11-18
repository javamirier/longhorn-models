using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LonghornMusic.Models
{
    public class Employee : AppUser
    {
        [Required(ErrorMessage="Social Security Number is required.")]
        [Display(Name = "Social Security Number")]
        public string SSN { get; set; }

    }
}