using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace benchmark.Migrations
{
    public partial class ExpandTpcE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "BMTpcE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HardwareVendor",
                table: "BMTpcE",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InitialDatabaseSizeGB",
                table: "BMTpcE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemorySizeGB",
                table: "BMTpcE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "BMTpcE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpindleCount",
                table: "BMTpcE",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "SystemAvailability",
                table: "BMTpcE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SystemModel",
                table: "BMTpcE",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalSystemCost",
                table: "BMTpcE",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TpcEnergyMetric",
                table: "BMTpcE",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "BMTpcE");

            migrationBuilder.DropColumn(
                name: "HardwareVendor",
                table: "BMTpcE");

            migrationBuilder.DropColumn(
                name: "InitialDatabaseSizeGB",
                table: "BMTpcE");

            migrationBuilder.DropColumn(
                name: "MemorySizeGB",
                table: "BMTpcE");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "BMTpcE");

            migrationBuilder.DropColumn(
                name: "SpindleCount",
                table: "BMTpcE");

            migrationBuilder.DropColumn(
                name: "SystemAvailability",
                table: "BMTpcE");

            migrationBuilder.DropColumn(
                name: "SystemModel",
                table: "BMTpcE");

            migrationBuilder.DropColumn(
                name: "TotalSystemCost",
                table: "BMTpcE");

            migrationBuilder.DropColumn(
                name: "TpcEnergyMetric",
                table: "BMTpcE");
        }
    }
}
