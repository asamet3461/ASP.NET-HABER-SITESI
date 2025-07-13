using Microsoft.EntityFrameworkCore;
using UluHaber.Entities;

namespace UluHaber.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet'ler
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
            var today = new DateTime(2025, 1, 15, 0, 0, 0);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Email = "admin@uluhaber.com",
                    Password = "admin123",
                    FirstName = "Admin",
                    LastName = "User",
                    IsAuthor = true,
                    IsAdmin = true,
                    IsActive = true,
                    EmailConfirmed = true,
                    CreatedAt = today,
                    UpdatedAt = today
                }
            );

         
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Ana Sayfa",
                    Slug = "ana-sayfa",
                    Description = "Ana sayfa kategorisi",
                    IsActive = true,
                    DisplayOrder = 1,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 2,
                    Name = "Dünya",
                    Slug = "dunya",
                    Description = "Dünya haberleri",
                    IsActive = true,
                    DisplayOrder = 2,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 3,
                    Name = "Türkiye",
                    Slug = "turkiye",
                    Description = "Türkiye haberleri",
                    IsActive = true,
                    DisplayOrder = 3,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 4,
                    Name = "Teknoloji",
                    Slug = "teknoloji",
                    Description = "Teknoloji haberleri",
                    IsActive = true,
                    DisplayOrder = 4,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 5,
                    Name = "Tasarım",
                    Slug = "tasarim",
                    Description = "Tasarım haberleri",
                    IsActive = true,
                    DisplayOrder = 5,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 6,
                    Name = "Kültür",
                    Slug = "kultur",
                    Description = "Kültür haberleri",
                    IsActive = true,
                    DisplayOrder = 6,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 7,
                    Name = "İş Dünyası",
                    Slug = "is-dunyasi",
                    Description = "İş dünyası haberleri",
                    IsActive = true,
                    DisplayOrder = 7,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 8,
                    Name = "Siyaset",
                    Slug = "siyaset",
                    Description = "Siyaset haberleri",
                    IsActive = true,
                    DisplayOrder = 8,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 9,
                    Name = "Görüş",
                    Slug = "gorus",
                    Description = "Görüş yazıları",
                    IsActive = true,
                    DisplayOrder = 9,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 10,
                    Name = "Bilim",
                    Slug = "bilim",
                    Description = "Bilim haberleri",
                    IsActive = true,
                    DisplayOrder = 10,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 11,
                    Name = "Sağlık",
                    Slug = "saglik",
                    Description = "Sağlık haberleri",
                    IsActive = true,
                    DisplayOrder = 11,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 12,
                    Name = "Yaşam",
                    Slug = "yasam",
                    Description = "Yaşam haberleri",
                    IsActive = true,
                    DisplayOrder = 12,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                },
                new Category
                {
                    Id = 13,
                    Name = "Seyahat",
                    Slug = "seyahat",
                    Description = "Seyahat haberleri",
                    IsActive = true,
                    DisplayOrder = 13,
                    IsFeatured = true,
                    ShowInSidebar = true,
                    CreatedAt = today,
                    UpdatedAt = today
                }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LOCALDB)\MSSQLLocalDB; database= UluHaber; integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}