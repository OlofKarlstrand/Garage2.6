using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Garage2._6.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        [DisplayName("Pilot First Name")]
        public string FirstName { get; set; }
        [DisplayName("Pilot Last Name")]
        public string LastName { get; set; }
            
        public string Email { get; set; }

     
    }
}