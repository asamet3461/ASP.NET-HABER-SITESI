using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UluHaber.Entities
{
    public class Post
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [StringLength(200, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Başlık")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [StringLength(200, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "URL Başlığı")]
        public string Slug { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [Display(Name = "İçerik")]
        public string Content { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Özet")]
        public string? Summary { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }

        [StringLength(500, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Ana Görsel")]
        public string? FeaturedImage { get; set; }

        [Display(Name = "Yayınlandı")]
        public bool IsPublished { get; set; } = false;

        [Display(Name = "Öne Çıkan")]
        public bool IsFeatured { get; set; } = false;

        [Display(Name = "Son Dakika")]
        public bool IsBreakingNews { get; set; } = false;

        [Display(Name = "Yayın Tarihi")]
        public DateTime? PublishedAt { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [Display(Name = "Yazar")]
        public int AuthorId { get; set; }

        [StringLength(100, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Yazar Adı")]
        public string AuthorName { get; set; } = string.Empty;

        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Güncellenme Tarihi")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

      
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

        [ForeignKey("AuthorId")]
        public virtual User? Author { get; set; }
    }
}
