using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Garage2._6.Models
{
    public class Member
    {
        
        public int MemberId { get; set; }

        [Required]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        
        [Required(ErrorMessage = "Phone Number Required")]        
        [DisplayName("Phone Number")]
        public string PhoneNr { get; set; }


        public virtual ICollection<ParkedVehicle> ParkedVehicles { get; set; }
    }
}

