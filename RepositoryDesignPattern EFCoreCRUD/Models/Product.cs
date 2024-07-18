using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryDesignPattern_EFCoreCRUD.Models
{
    [Table("Product")]
    public class Product
    {
       public long ProductId { get; set; }
       public string ProductName { get; set; } 
       public string ProductCategory {  get; set; }
       public string ProductDescription { get; set; }
   
    }
}
