using System.ComponentModel.DataAnnotations;

namespace MockWebApp.Models.Entities
{
    public class Provider
    {
        [Key]
        public int SPId { get; set; }
        public string SPName { get; set; }
        public string SPType { get; set; }

    
    }
}
