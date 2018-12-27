using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookTitlesDisplay.Models
{
    public class SearchStringX
    {
        [StringLength(20, MinimumLength = 3)]
        [Display(Name="Search")]
        public string InputString { get; set; }

    }
}