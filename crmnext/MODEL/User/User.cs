using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.User
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public string Email { get; set; }
        [Required]
        [EmailAddress]
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IsActive { get; set; }

        public int Role { get; set; }
    }
}
