using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    [Key]
    public int Product_Id { get; set; }
    public String? Product_Name { get; set; } = String.Empty;
    public decimal Product_Price { get; set; }
}
