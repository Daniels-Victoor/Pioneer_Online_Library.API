
using Microsoft.AspNet.Identity.EntityFramework;
using Pioneer_Online_Library.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pioneer_Online_Library.Domain.Model
{
    public class AppUser : IdentityUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public virtual Role Role { get; set; }
    }

}



