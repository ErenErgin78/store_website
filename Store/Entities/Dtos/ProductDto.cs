using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int Product_Id { get; init; }

        [Required(ErrorMessage = "Product Name can't be empty")]
        public String? Product_Name { get; init; } = String.Empty;

        [Required(ErrorMessage = "Product Price can't be empty")]
        public decimal Product_Price { get; init; }
        public String? Product_Summary { get; init; } = String.Empty;
        public String? Product_ImageUrl { get; set; }
        public int? CategoryId { get; init; }
    }
}