using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace HealthInsurenceSystem.Models
{
    public partial class Contact
    {
        [Key]
       
        public string Name { get; set; }
        
        public string Mnumber { get; set; }
        
        public string Subject { get; set; }
    }
}
