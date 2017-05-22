using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace benchmark.Migrations
{
    public partial class AddCalculatedMembersToTpce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CoreCount",
                table: "Processors",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClockSpeedMhz",
                table: "Processors",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CoreCount",
                table: "Processors",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClockSpeedMhz",
                table: "Processors",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
