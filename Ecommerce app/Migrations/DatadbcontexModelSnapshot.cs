﻿// <auto-generated />
using Ecommerce_app.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce_app.Migrations
{
    [DbContext(typeof(Datadbcontext))]
    partial class DatadbcontexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce_app.Data.product", b =>
                {
                    b.Property<int>("Product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Product_id"));

                    b.Property<int>("Product_detail")
                        .HasColumnType("int");

                    b.Property<int>("Product_name")
                        .HasColumnType("int");

                    b.Property<int>("Product_url")
                        .HasColumnType("int");

                    b.HasKey("Product_id");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
