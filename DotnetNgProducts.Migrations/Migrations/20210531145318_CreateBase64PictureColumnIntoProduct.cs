using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotnetNgProducts.Migrations.Migrations
{
    public partial class CreateBase64PictureColumnIntoProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Base64Picture",
                table: "Products",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base64Picture",
                table: "Products");
        }
    }
}
