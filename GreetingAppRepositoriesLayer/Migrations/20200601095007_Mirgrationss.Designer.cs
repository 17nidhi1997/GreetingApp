﻿// <auto-generated />
using GreetingAppRepositoriesLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GreetingAppRepositoriesLayer.Migrations
{
    [DbContext(typeof(RepoDbContext))]
    [Migration("20200601095007_Mirgrationss")]
    partial class Mirgrationss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GreetingAppCommannLayer.GreetingModel", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailId")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Salary")
                        .IsRequired();

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
