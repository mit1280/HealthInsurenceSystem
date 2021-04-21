using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Policy
    {
        [Key]
        [StringLength(50, ErrorMessage = "Add Policy")]
        public string Ptype { get; set; }
     
        public int? MinAge { get; set; }
        
        public int? MaxAge { get; set; }
        public int? MonthPremium { get; set; }
        public int? Duration { get; set; }
    }
}
