using Microsoft.EntityFrameworkCore.Migrations;

namespace XSS_Rootkit.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competition",
                columns: table => new
                {
                    BrandID = table.Column<string>(type: "VARCHAR (5)", nullable: false),
                    BrandName = table.Column<string>(type: "VARCHAR (50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Flag",
                columns: table => new
                {
                    FlagID = table.Column<string>(nullable: false),
                    FlagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flag", x => x.FlagID);
                });

            migrationBuilder.InsertData(
                table: "Competition",
                columns: new[] { "BrandID", "BrandName" },
                values: new object[] { "1", "Nike" });

            migrationBuilder.InsertData(
                table: "Competition",
                columns: new[] { "BrandID", "BrandName" },
                values: new object[] { "2", "Adidas" });

            migrationBuilder.InsertData(
                table: "Competition",
                columns: new[] { "BrandID", "BrandName" },
                values: new object[] { "3", "Puma" });

            migrationBuilder.InsertData(
                table: "Competition",
                columns: new[] { "BrandID", "BrandName" },
                values: new object[] { "4", "Under Armour" });

            migrationBuilder.InsertData(
                table: "Competition",
                columns: new[] { "BrandID", "BrandName" },
                values: new object[] { "5", "Sketchers" });

            migrationBuilder.InsertData(
                table: "Flag",
                columns: new[] { "FlagID", "FlagName" },
                values: new object[] { "1", "byu22ind{databa5e}" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Competition");

            migrationBuilder.DropTable(
                name: "Flag");
        }
    }
}
