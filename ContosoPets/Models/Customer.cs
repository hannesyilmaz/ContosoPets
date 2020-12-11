using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoPets.Models
{
    public class Customer
    {
#nullable enable    // this has to be declared for nullable to be applied
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; } // ? provides nullable access so that those values can be null
        public string? Phone { get; set; }
        public string Email { get; set; }
#nullable disable
        public ICollection<Order> Orders { get; set; }

    }
}
