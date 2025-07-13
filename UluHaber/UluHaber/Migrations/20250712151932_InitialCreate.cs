using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UluHaber.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    ShowInSidebar = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsAuthor = table.Column<bool>(type: "bit", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LastLoginAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    FeaturedImage = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    IsFeatured = table.Column<bool>(type: "bit", nullable: false),
                    IsBreakingNews = table.Column<bool>(type: "bit", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Color", "CreatedAt", "Description", "DisplayOrder", "Icon", "IsActive", "IsFeatured", "Name", "ShowInSidebar", "Slug", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana sayfa kategorisi", 1, null, true, true, "Ana Sayfa", true, "ana-sayfa", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dünya haberleri", 2, null, true, true, "Dünya", true, "dunya", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Türkiye haberleri", 3, null, true, true, "Türkiye", true, "turkiye", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teknoloji haberleri", 4, null, true, true, "Teknoloji", true, "teknoloji", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tasarım haberleri", 5, null, true, true, "Tasarım", true, "tasarim", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kültür haberleri", 6, null, true, true, "Kültür", true, "kultur", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "İş dünyası haberleri", 7, null, true, true, "İş Dünyası", true, "is-dunyasi", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Siyaset haberleri", 8, null, true, true, "Siyaset", true, "siyaset", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Görüş yazıları", 9, null, true, true, "Görüş", true, "gorus", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilim haberleri", 10, null, true, true, "Bilim", true, "bilim", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sağlık haberleri", 11, null, true, true, "Sağlık", true, "saglik", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yaşam haberleri", 12, null, true, true, "Yaşam", true, "yasam", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seyahat haberleri", 13, null, true, true, "Seyahat", true, "seyahat", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "IsActive", "IsAdmin", "IsAuthor", "LastLoginAt", "LastName", "Password", "UpdatedAt", "Username" },
                values: new object[] { 1, null, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@uluhaber.com", true, "Admin", true, true, true, null, "User", "admin123", new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
