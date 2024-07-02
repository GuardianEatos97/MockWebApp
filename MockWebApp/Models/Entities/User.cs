using Microsoft.EntityFrameworkCore;

namespace MockWebApp.Models.Entities
{
    public class User
    {
        
        public Guid Id { get; set; }
        public int Jersey { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string Team { get; set; }
    
    }
}
