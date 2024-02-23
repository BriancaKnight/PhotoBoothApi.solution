using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoBoothApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Booths",
                columns: new[] { "BoothId", "Address", "Color", "Location", "Neighborhood", "Type" },
                values: new object[,]
                {
                    { 1, "435 N Killingsworth St, Portland, OR 97217", "Both", "The Florida Room", "NE", "Digital" },
                    { 2, "1026 SW Harvey Milk St, Portland, OR 97205", "B&W", "Stumptown Coffee", "SW", "Film" },
                    { 3, "1829 NE Alberta St ste c, Portland, OR 9721", "Both", "Psychic Sister", "NE", "Digital" },
                    { 4, "4800 SE Hawthorne Blvd, Portland, OR 97215", "Both", "Space Room Lounge", "SE", "Digital" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Booths",
                keyColumn: "BoothId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Booths",
                keyColumn: "BoothId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Booths",
                keyColumn: "BoothId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Booths",
                keyColumn: "BoothId",
                keyValue: 4);
        }
    }
}
