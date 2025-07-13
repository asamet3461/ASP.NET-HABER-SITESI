using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Collections.Generic; // <-- Bunu da ekle

namespace UluHaber.Entities
{
    public class Category
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [StringLength(100, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Kategori Adı")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [StringLength(100, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "URL Adı")]
        public string Slug { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }

        [StringLength(50, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "İkon")]
        public string? Icon { get; set; }

        [StringLength(20, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Renk")]
        public string? Color { get; set; }

        [Display(Name = "Aktif")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "Sıralama")]
        public int DisplayOrder { get; set; } = 0;

        [Display(Name = "Öne Çıkan")]
        public bool IsFeatured { get; set; } = false;

        [Display(Name = "Sidebar'da Göster")]
        public bool ShowInSidebar { get; set; } = true;

        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Güncellenme Tarihi")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}