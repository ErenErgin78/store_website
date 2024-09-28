using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        public String Category_Name { get; set;} = String.Empty;

        //Collection navigation property
        public ICollection<Product> Products{ get; set; }
    }
}