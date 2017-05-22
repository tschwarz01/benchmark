using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace benchmark.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcessorBrands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    BrandName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessorBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCodenames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Codename = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCodenames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductFamilies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    FamilyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFamilies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSeries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    SeriesName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Cache = table.Column<string>(nullable: true),
                    CacheKB = table.Column<int>(nullable: true),
                    CacheType = table.Column<string>(nullable: true),
                    ClockSpeedMaxMhz = table.Column<double>(nullable: true),
                    ClockSpeedMhz = table.Column<int>(nullable: true),
                    CoreCount = table.Column<int>(nullable: true),
                    LaunchDate = table.Column<DateTime>(nullable: true),
                    MarketSegment = table.Column<string>(nullable: true),
                    MaxCPUs = table.Column<int>(nullable: true),
                    ProcessorBrandId = table.Column<int>(nullable: true),
                    ProcessorNumber = table.Column<string>(nullable: true),
                    ProductCodenameId = table.Column<int>(nullable: true),
                    ProductFamilyId = table.Column<int>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductNameDetails = table.Column<string>(nullable: true),
                    ProductNameFull = table.Column<string>(nullable: true),
                    ProductSeriesId = table.Column<int>(nullable: true),
                    ThreadCount = table.Column<int>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processors_ProcessorBrands_ProcessorBrandId",
                        column: x => x.ProcessorBrandId,
                        principalTable: "ProcessorBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processors_ProductCodenames_ProductCodenameId",
                        column: x => x.ProductCodenameId,
                        principalTable: "ProductCodenames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processors_ProductFamilies_ProductFamilyId",
                        column: x => x.ProductFamilyId,
                        principalTable: "ProductFamilies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Processors_ProductSeries_ProductSeriesId",
                        column: x => x.ProductSeriesId,
                        principalTable: "ProductSeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BMTpcE",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CoreCount = table.Column<int>(nullable: false),
                    ProcessorCount = table.Column<int>(nullable: false),
                    ProcessorId = table.Column<int>(nullable: true),
                    ProductSeriesId = table.Column<int>(nullable: true),
                    ResultSubmitted = table.Column<DateTime>(nullable: false),
                    ThreadCount = table.Column<int>(nullable: false),
                    TpsE = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BMTpcE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BMTpcE_Processors_ProcessorId",
                        column: x => x.ProcessorId,
                        principalTable: "Processors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BMTpcE_ProductSeries_ProductSeriesId",
                        column: x => x.ProductSeriesId,
                        principalTable: "ProductSeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Processors_ProcessorBrandId",
                table: "Processors",
                column: "ProcessorBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Processors_ProductCodenameId",
                table: "Processors",
                column: "ProductCodenameId");

            migrationBuilder.CreateIndex(
                name: "IX_Processors_ProductFamilyId",
                table: "Processors",
                column: "ProductFamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Processors_ProductSeriesId",
                table: "Processors",
                column: "ProductSeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_BMTpcE_ProcessorId",
                table: "BMTpcE",
                column: "ProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_BMTpcE_ProductSeriesId",
                table: "BMTpcE",
                column: "ProductSeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BMTpcE");

            migrationBuilder.DropTable(
                name: "Processors");

            migrationBuilder.DropTable(
                name: "ProcessorBrands");

            migrationBuilder.DropTable(
                name: "ProductCodenames");

            migrationBuilder.DropTable(
                name: "ProductFamilies");

            migrationBuilder.DropTable(
                name: "ProductSeries");
        }
    }
}
