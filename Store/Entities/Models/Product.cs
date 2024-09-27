using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    [Key]
    public int Product_Id { get; set; }

    [Required(ErrorMessage = "Product Name is required")]
    public String? Product_Name { get; set; } = String.Empty;

    [Required(ErrorMessage = "Product Price is required")]
    public decimal Product_Price { get; set; }
}
