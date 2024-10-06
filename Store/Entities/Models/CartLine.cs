namespace Entities.Models
{
    public class CartLine
    {
            public int CartLine_Id { get; set;}
            public Product Product { get; set;} = new();
            public int Quantity { get; set; }
    } 

}