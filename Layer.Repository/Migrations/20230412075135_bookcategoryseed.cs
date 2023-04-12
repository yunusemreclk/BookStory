using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Layer.Repository.Migrations
{
    public partial class bookcategoryseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Book_Categories",
                columns: new[] { "ID", "BookID", "CategoryID" },
                values: new object[,]
                {
                    { 1, 1, 3 },
                    { 2, 1, 7 },
                    { 3, 2, 3 },
                    { 4, 2, 7 },
                    { 5, 2, 8 },
                    { 6, 3, 7 },
                    { 7, 4, 3 },
                    { 8, 4, 7 },
                    { 9, 4, 2 },
                    { 10, 5, 7 },
                    { 11, 6, 9 },
                    { 12, 7, 7 },
                    { 13, 7, 2 },
                    { 14, 8, 7 },
                    { 15, 9, 1 },
                    { 16, 9, 4 },
                    { 17, 10, 9 },
                    { 18, 10, 8 },
                    { 19, 11, 6 },
                    { 20, 12, 4 },
                    { 21, 13, 4 },
                    { 22, 14, 4 },
                    { 23, 15, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Book_Categories",
                keyColumn: "ID",
                keyValue: 23);
        }
    }
}
