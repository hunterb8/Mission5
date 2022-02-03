using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    film_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category_id = table.Column<int>(nullable: false),
                    category_id1 = table.Column<int>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: true),
                    rating = table.Column<string>(nullable: true),
                    edited = table.Column<bool>(nullable: false),
                    lent_to = table.Column<string>(nullable: true),
                    notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.film_id);
                    table.ForeignKey(
                        name: "FK_Films_Categories_category_id1",
                        column: x => x.category_id1,
                        principalTable: "Categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "film_id", "category_id", "category_id1", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 1, 1, null, "John Doe", false, "", "", "PG-13", "Casino Royale", 2006 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "film_id", "category_id", "category_id1", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 2, 1, null, "John Doe", false, "", "", "PG-13", "Skyfall", 2013 });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "film_id", "category_id", "category_id1", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 3, 1, null, "John Doe", false, "", "", "PG-13", "No Time To Die", 2021 });

            migrationBuilder.CreateIndex(
                name: "IX_Films_category_id1",
                table: "Films",
                column: "category_id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
