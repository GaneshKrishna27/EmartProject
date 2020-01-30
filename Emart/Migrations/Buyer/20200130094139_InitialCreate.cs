using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Emart.Migrations.Buyer
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "buyer",
                columns: table => new
                {
                    Bid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bname = table.Column<string>(maxLength: 20, nullable: false),
                    Bpwd = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buyer", x => x.Bid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "buyer");
        }
    }
}
