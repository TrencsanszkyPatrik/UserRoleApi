using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime RegTime { get; set; }
    }
}
