using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {     
    public int Product_Id { get; set; }

    [Required(ErrorMessage = "Product Name can't be empty")]
    public String? Product_Name { get; set; } = String.Empty;

    [Required(ErrorMessage = "Product Price can't be empty")]
    public decimal Product_Price { get; set; }
    public int? CategoryId{ get; set; }
    }
}