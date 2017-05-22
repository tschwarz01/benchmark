using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace benchmark.Migrations
{
    public partial class TryFixingNavProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processors_ProcessorBrands_ProcessorBrandId",
                table: "Processors");

            migrationBuilder.DropForeignKey(
                name: "FK_Processors_ProductCodenames_ProductCodenameId",
                table: "Processors");

            migrationBuilder.DropForeignKey(
                name: "FK_Processors_ProductFamilies_ProductFamilyId",
                table: "Processors");

            migrationBuilder.DropForeignKey(
                name: "FK_Processors_ProductSeries_ProductSeriesId",
                table: "Processors");

            migrationBuilder.AlterColumn<int>(
                name: "ProductSeriesId",
                table: "Processors",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductFamilyId",
                table: "Processors",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductCodenameId",
                table: "Processors",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProcessorBrandId",
                table: "Processors",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_ProcessorBrands_ProcessorBrandId",
                table: "Processors",
                column: "ProcessorBrandId",
                principalTable: "ProcessorBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_ProductCodenames_ProductCodenameId",
                table: "Processors",
                column: "ProductCodenameId",
                principalTable: "ProductCodenames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_ProductFamilies_ProductFamilyId",
                table: "Processors",
                column: "ProductFamilyId",
                principalTable: "ProductFamilies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_ProductSeries_ProductSeriesId",
                table: "Processors",
                column: "ProductSeriesId",
                principalTable: "ProductSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processors_ProcessorBrands_ProcessorBrandId",
                table: "Processors");

            migrationBuilder.DropForeignKey(
                name: "FK_Processors_ProductCodenames_ProductCodenameId",
                table: "Processors");

            migrationBuilder.DropForeignKey(
                name: "FK_Processors_ProductFamilies_ProductFamilyId",
                table: "Processors");

            migrationBuilder.DropForeignKey(
                name: "FK_Processors_ProductSeries_ProductSeriesId",
                table: "Processors");

            migrationBuilder.AlterColumn<int>(
                name: "ProductSeriesId",
                table: "Processors",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductFamilyId",
                table: "Processors",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProductCodenameId",
                table: "Processors",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProcessorBrandId",
                table: "Processors",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_ProcessorBrands_ProcessorBrandId",
                table: "Processors",
                column: "ProcessorBrandId",
                principalTable: "ProcessorBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_ProductCodenames_ProductCodenameId",
                table: "Processors",
                column: "ProductCodenameId",
                principalTable: "ProductCodenames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_ProductFamilies_ProductFamilyId",
                table: "Processors",
                column: "ProductFamilyId",
                principalTable: "ProductFamilies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Processors_ProductSeries_ProductSeriesId",
                table: "Processors",
                column: "ProductSeriesId",
                principalTable: "ProductSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
