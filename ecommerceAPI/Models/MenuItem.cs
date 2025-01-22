using System.ComponentModel.DataAnnotations;

namespace ecommerceAPI.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SpecialTag { get; set; }
        public string Category { get; set; }
        [Range(1,int.MaxValue)]
        public double Price { get; set; }
        [Required]
        public string Image { get; set; }
    }
}
