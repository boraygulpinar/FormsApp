using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
    public class Product
    {
        [Display(Name = "Ürün ID")]
        public int ProductId { get; set; }


        [Required]
        [Display(Name = "Ürün Adı")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Fiyat")]
        public decimal? Price { get; set; }

        [Required]
        [Display(Name = "Görsel")]
        public string? Image { get; set; }


        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        [Required]
        [Display(Name = "Kategori")]
        public int? CategoryId { get; set; }
    }
}
