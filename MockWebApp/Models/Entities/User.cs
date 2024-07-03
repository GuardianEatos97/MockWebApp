using Microsoft.EntityFrameworkCore;

namespace MockWebApp.Models.Entities
{
    public class User
    {
        
        public int Id { get; set; }
        public string? UserPic { get; set; }    
        public int UserJersey { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserTeam { get; set; }
    
    }
}
