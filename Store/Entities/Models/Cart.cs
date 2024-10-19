namespace Entities.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; }
        public Cart()
        {
            Lines = new List<CartLine>();
        }

        public virtual void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines.Where(i => i.Product.Product_Id.Equals(product.Product_Id)).FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(Product product) =>
        Lines.RemoveAll(i => i.Product.Product_Id.Equals(product.Product_Id));
        public decimal ComputeTotalValue() => Lines.Sum(i => i.Product.Product_Price * i.Quantity);
        public virtual void Clear() => Lines.Clear();
    }
}