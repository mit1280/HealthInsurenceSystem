using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Payment
    {
        [Key]
        [StringLength(16, ErrorMessage = "Check Card Number")]
        public string Cardnumber { get; set; }
        [Range(100, 999, ErrorMessage = "Check you CVV")]
        public int Cvv { get; set; }
        [StringLength(7, ErrorMessage = "Check Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/yyyy}")]
        public string ExpiredDate { get; set; }
    }
}
