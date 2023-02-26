using System.ComponentModel.DataAnnotations;

namespace Productos
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
