﻿// <auto-generated />
using CoreWebAPI2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreWebAPI2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoreWebAPI2.Model.Text", b =>
                {
                    b.Property<long>("TextId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TextId"), 1L, 1);

                    b.Property<string>("TextString")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TextId");

                    b.ToTable("TextTable");

                    b.HasData(
                        new
                        {
                            TextId = 1L,
                            TextString = "Numbers and alphabets are the basic teachings that a child learns in the house even before his steps reach the door of the school. This is the main foundation of their learning process. As the child starts going to school, he/she discovers how to spell words and numbers. They learn to differentiate the sounds and pronunciation of the words and numbers. And finally, they understand why we use numbers and words. These simple components become an undeniable part of their existence then and in the years to come. Be it anywhere in life, numbers are a facet no one can wave away. Be it in everyday usage or in making important decisions, numbers have a chance in representing facts which wouldn’t be possible otherwise. "
                        });
                });
#pragma warning restore 612, 618
        }
    }
}