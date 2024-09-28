using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Product
{
    [Key]
    public int Product_Id { get; set; }

    [Required(ErrorMessage = "Product Name can't be empty")]
    public String? Product_Name { get; set; } = String.Empty;

    [Required(ErrorMessage = "Product Price can't be empty")]
    public decimal Product_Price { get; set; }
    public int? CategoryId{ get; set; }
    public Category? Category{ get; set; } //Navigation Property
}
