﻿// <auto-generated />
using DataAccess.Layer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Layer.Migrations
{
    [DbContext(typeof(OkulDb))]
    partial class OkulDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Layer.Entity.Bölüm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BölümName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FakülteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FakülteId");

                    b.ToTable("Bölümler");
                });

            modelBuilder.Entity("DataAccess.Layer.Entity.Fakülte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FakülteName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fakülteler");
                });

            modelBuilder.Entity("DataAccess.Layer.Entity.Bölüm", b =>
                {
                    b.HasOne("DataAccess.Layer.Entity.Fakülte", "Fakülte")
                        .WithMany("Bölümler")
                        .HasForeignKey("FakülteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fakülte");
                });

            modelBuilder.Entity("DataAccess.Layer.Entity.Fakülte", b =>
                {
                    b.Navigation("Bölümler");
                });
#pragma warning restore 612, 618
        }
    }
}
