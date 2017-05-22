using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace benchmark.Migrations
{
    public partial class TweakingTpce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BMTpcE_Processors_ProcessorId",
                table: "BMTpcE");

            migrationBuilder.DropForeignKey(
                name: "FK_BMTpcE_ProductSeries_ProductSeriesId",
                table: "BMTpcE");

            migrationBuilder.DropIndex(
                name: "IX_BMTpcE_ProcessorId",
                table: "BMTpcE");

            migrationBuilder.DropIndex(
                name: "IX_BMTpcE_ProductSeriesId",
                table: "BMTpcE");

            migrationBuilder.AlterColumn<int>(
                name: "ProductSeriesId",
                table: "BMTpcE",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProcessorId",
                table: "BMTpcE",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProductSeriesId",
                table: "BMTpcE",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProcessorId",
                table: "BMTpcE",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_BMTpcE_ProcessorId",
                table: "BMTpcE",
                column: "ProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_BMTpcE_ProductSeriesId",
                table: "BMTpcE",
                column: "ProductSeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_BMTpcE_Processors_ProcessorId",
                table: "BMTpcE",
                column: "ProcessorId",
                principalTable: "Processors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BMTpcE_ProductSeries_ProductSeriesId",
                table: "BMTpcE",
                column: "ProductSeriesId",
                principalTable: "ProductSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
