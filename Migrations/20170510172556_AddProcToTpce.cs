using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace benchmark.Migrations
{
    public partial class AddProcToTpce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BMTpcE_ProcessorId",
                table: "BMTpcE",
                column: "ProcessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_BMTpcE_Processors_ProcessorId",
                table: "BMTpcE",
                column: "ProcessorId",
                principalTable: "Processors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BMTpcE_Processors_ProcessorId",
                table: "BMTpcE");

            migrationBuilder.DropIndex(
                name: "IX_BMTpcE_ProcessorId",
                table: "BMTpcE");
        }
    }
}
