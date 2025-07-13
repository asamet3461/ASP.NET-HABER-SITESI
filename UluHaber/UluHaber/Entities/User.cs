using System.ComponentModel.DataAnnotations;

namespace UluHaber.Entities
{
    public class User
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [StringLength(50, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [StringLength(100, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [EmailAddress(ErrorMessage = "Geçerli bir {0} giriniz")]
        [Display(Name = "E-posta")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [StringLength(100, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Şifre")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [StringLength(50, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Ad")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "{0} alanı zorunludur")]
        [StringLength(50, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Soyad")]
        public string LastName { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "{0} en fazla {1} karakter olabilir")]
        [Display(Name = "Hakkında")]
        public string? Bio { get; set; }

        [Display(Name = "Yazar")]
        public bool IsAuthor { get; set; } = true;

        [Display(Name = "Yönetici")]
        public bool IsAdmin { get; set; } = false;

        [Display(Name = "Aktif")]
        public bool IsActive { get; set; } = true;

        [Display(Name = "E-posta Onaylandı")]
        public bool EmailConfirmed { get; set; } = false;

        [Display(Name = "Son Giriş Tarihi")]
        public DateTime? LastLoginAt { get; set; }

        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Güncellenme Tarihi")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        
        public virtual ICollection<Post>? Posts { get; set; }
    }
}
