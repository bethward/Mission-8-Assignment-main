using Microsoft.EntityFrameworkCore.Migrations;

namespace BookProject.Migrations
{
    public partial class Bethany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Publisher = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(nullable: false),
                    Classification = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    PageCount = table.Column<long>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 1L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 20L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 19L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 18L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 17L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 16L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 15L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 14L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 13L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 12L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 11L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 10L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 9L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 8L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 7L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 6L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 5L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 4L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 3L, "Laura Hillenbrand", "Historical", "Non-Fiction", "978-0812974492", 538L, 13.329999923706055, "Random House", "Unbroken" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 2L, "Doris Kearns Goodwin", "Biography", "Non-Fiction", "978-0743270755", 944L, 14.579999923706055, "Simon & Schuster", "Team of Rivals" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 21L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Category", "Classification", "ISBN", "PageCount", "Price", "Publisher", "Title" },
                values: new object[] { 22L, "Victor Hugo", "Classic", "Fiction", "978-0451419439", 1488L, 9.9499998092651367, "Signet", "Les Miserables" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
