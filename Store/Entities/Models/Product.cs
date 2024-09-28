using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Product
{
    [Key]
    public int Product_Id { get; init; }
    public String? Product_Name { get; init; } = String.Empty;
    public decimal Product_Price { get; init; }
    public int? CategoryId{ get; init; }
    public Category? Category{ get; init; } //Navigation Property
}
