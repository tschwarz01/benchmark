using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace benchmark.Migrations
{
    public partial class FixCodenames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodenameType",
                table: "ProductCodenames",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlText",
                table: "ProductCodenames",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodenameType",
                table: "ProductCodenames");

            migrationBuilder.DropColumn(
                name: "UrlText",
                table: "ProductCodenames");
        }
    }
}
