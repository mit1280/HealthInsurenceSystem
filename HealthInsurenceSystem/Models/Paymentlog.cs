using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Paymentlog
    {
        [Key]
        public int Paymentnumber { get; set; }
        public int Pnumber { get; set; }
        public string Cemail { get; set; }
        public DateTime? Paymentdate { get; set; }
    }
}
