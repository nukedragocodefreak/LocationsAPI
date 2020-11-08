using System;
using System.Collections.Generic;
using System.Text;

namespace Locations.Core.Models.Users
{
    public class Users
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
