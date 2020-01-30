using Microsoft.EntityFrameworkCore.Migrations;

namespace Emart.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "seller",
                columns: table => new
                {
                    Sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sname = table.Column<string>(maxLength: 20, nullable: false),
                    Spwd = table.Column<string>(nullable: false),
                    Companyname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Gstin = table.Column<double>(nullable: false),
                    Bank_Details = table.Column<string>(nullable: false),
                    Postal_Address = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seller", x => x.Sid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "seller");
        }
    }
}
