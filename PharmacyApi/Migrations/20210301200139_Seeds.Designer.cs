﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyApi.Storing;

namespace PharmacyApi.Migrations
{
    [DbContext(typeof(PharmacyContext))]
    [Migration("20210301200139_Seeds")]
    partial class Seeds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PharmacyApi.Models.Drug", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Dose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PatientEntityId")
                        .HasColumnType("bigint");

                    b.Property<string>("Presciber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isLiquid")
                        .HasColumnType("bit");

                    b.HasKey("EntityId");

                    b.HasIndex("PatientEntityId");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("PharmacyApi.Models.Patient", b =>
                {
                    b.Property<long>("EntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EntityId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PharmacyApi.Models.Drug", b =>
                {
                    b.HasOne("PharmacyApi.Models.Patient", null)
                        .WithMany("Drugs")
                        .HasForeignKey("PatientEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PharmacyApi.Models.Patient", b =>
                {
                    b.Navigation("Drugs");
                });
#pragma warning restore 612, 618
        }
    }
}
