using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladoMurex.Domain.Entities.Users
{
    public class Users
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
