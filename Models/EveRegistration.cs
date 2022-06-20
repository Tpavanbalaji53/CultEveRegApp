using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CulturalEventRegistrationApp.Models
{
    public class EveRegistration
    {
        public long UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string ParticipateIn { get; set; }
        public DateTime DateOn { get; set; }
    }
}
