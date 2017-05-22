using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using benchmark.Infrastructure;

namespace benchmark.Migrations
{
    [DbContext(typeof(BenchDbContext))]
    [Migration("20170510184025_AddCalculatedMembersToTpce")]
    partial class AddCalculatedMembersToTpce
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("benchmark.Entities.Processor", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Cache");

                    b.Property<int?>("CacheKB");

                    b.Property<string>("CacheType");

                    b.Property<double?>("ClockSpeedMaxMhz");

                    b.Property<int>("ClockSpeedMhz");

                    b.Property<int>("CoreCount");

                    b.Property<DateTime?>("LaunchDate");

                    b.Property<string>("MarketSegment");

                    b.Property<int?>("MaxCPUs");

                    b.Property<int>("ProcessorBrandId");

                    b.Property<string>("ProcessorNumber");

                    b.Property<int>("ProductCodenameId");

                    b.Property<int>("ProductFamilyId");

                    b.Property<string>("ProductName");

                    b.Property<string>("ProductNameDetails");

                    b.Property<string>("ProductNameFull");

                    b.Property<int>("ProductSeriesId");

                    b.Property<int?>("ThreadCount");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("ProcessorBrandId");

                    b.HasIndex("ProductCodenameId");

                    b.HasIndex("ProductFamilyId");

                    b.HasIndex("ProductSeriesId");

                    b.ToTable("Processors");
                });

            modelBuilder.Entity("benchmark.Entities.ProcessorBrand", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("BrandName");

                    b.HasKey("Id");

                    b.ToTable("ProcessorBrands");
                });

            modelBuilder.Entity("benchmark.Entities.ProductCodename", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Codename");

                    b.Property<string>("CodenameType");

                    b.Property<string>("UrlText");

                    b.HasKey("Id");

                    b.ToTable("ProductCodenames");
                });

            modelBuilder.Entity("benchmark.Entities.ProductFamily", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("FamilyName");

                    b.HasKey("Id");

                    b.ToTable("ProductFamilies");
                });

            modelBuilder.Entity("benchmark.Entities.ProductSeries", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("SeriesName");

                    b.HasKey("Id");

                    b.ToTable("ProductSeries");
                });

            modelBuilder.Entity("benchmark.Entities.TpcE", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("ClientId");

                    b.Property<int>("CoreCount");

                    b.Property<string>("Currency");

                    b.Property<string>("HardwareVendor");

                    b.Property<int>("InitialDatabaseSizeGB");

                    b.Property<int>("MemorySizeGB");

                    b.Property<int>("ProcessorCount");

                    b.Property<int>("ProcessorId");

                    b.Property<int>("ProductSeriesId");

                    b.Property<DateTime>("ResultSubmitted");

                    b.Property<int>("ServerId");

                    b.Property<int>("SpindleCount");

                    b.Property<DateTime>("SystemAvailability");

                    b.Property<string>("SystemModel");

                    b.Property<int>("ThreadCount");

                    b.Property<decimal>("TotalSystemCost");

                    b.Property<string>("TpcEnergyMetric");

                    b.Property<double>("TpsE");

                    b.HasKey("Id");

                    b.HasIndex("ProcessorId");

                    b.ToTable("BMTpcE");
                });

            modelBuilder.Entity("benchmark.Entities.Processor", b =>
                {
                    b.HasOne("benchmark.Entities.ProcessorBrand", "ProcessorBrand")
                        .WithMany("Processors")
                        .HasForeignKey("ProcessorBrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("benchmark.Entities.ProductCodename", "ProductCodename")
                        .WithMany("Processors")
                        .HasForeignKey("ProductCodenameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("benchmark.Entities.ProductFamily", "ProductFamily")
                        .WithMany("Processors")
                        .HasForeignKey("ProductFamilyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("benchmark.Entities.ProductSeries", "ProductSeries")
                        .WithMany("Processors")
                        .HasForeignKey("ProductSeriesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("benchmark.Entities.TpcE", b =>
                {
                    b.HasOne("benchmark.Entities.Processor", "Processor")
                        .WithMany()
                        .HasForeignKey("ProcessorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
