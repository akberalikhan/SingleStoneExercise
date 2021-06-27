﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SingleStoneExercise.Models;

namespace SingleStoneExercise.Migrations
{
    [DbContext(typeof(ContactEntryContext))]
    partial class ContactEntryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SingleStoneExercise.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NameId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.HasIndex("NameId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("SingleStoneExercise.Models.Name", b =>
                {
                    b.Property<int>("NameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("First")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Middle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NameId");

                    b.ToTable("Names");
                });

            modelBuilder.Entity("SingleStoneExercise.Models.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneId");

                    b.HasIndex("AddressId");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("SingleStoneExercise.Models.Address", b =>
                {
                    b.HasOne("SingleStoneExercise.Models.Name", "Name")
                        .WithOne("Address")
                        .HasForeignKey("SingleStoneExercise.Models.Address", "NameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Name");
                });

            modelBuilder.Entity("SingleStoneExercise.Models.Phone", b =>
                {
                    b.HasOne("SingleStoneExercise.Models.Address", "Address")
                        .WithMany("Phones")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("SingleStoneExercise.Models.Address", b =>
                {
                    b.Navigation("Phones");
                });

            modelBuilder.Entity("SingleStoneExercise.Models.Name", b =>
                {
                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}