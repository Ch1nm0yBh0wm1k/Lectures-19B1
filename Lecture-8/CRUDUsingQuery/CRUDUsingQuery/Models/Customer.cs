using System.ComponentModel.DataAnnotations;

namespace CRUDUsingQuery.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
    }
}
