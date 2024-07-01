using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace MockWebApp.Models.Entities
{
    public class Excercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BodyPartID { get; set; }
    }
}
