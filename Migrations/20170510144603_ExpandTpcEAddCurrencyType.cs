using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace benchmark.Migrations
{
    public partial class ExpandTpcEAddCurrencyType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "BMTpcE",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "BMTpcE");
        }
    }
}
