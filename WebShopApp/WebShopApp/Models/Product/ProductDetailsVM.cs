using System.ComponentModel.DataAnnotations;

namespace WebShopApp.Models.Product
{
    public class ProductDetailsVM
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; } = null!;

        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        public string BrandName { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        [Display(Name = "Picture")]
        public string Picture { get; set; }

        [Range(0, 5000)]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Discount")]
        public decimal Discount { get; set; }

    }
}
