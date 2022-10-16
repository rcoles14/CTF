using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace XSS.Models
{
    public partial class Flag
    {
        [Key]
        [Required]
        public string FlagID { get; set; }
        public string FlagName { get; set; }
    }
}

