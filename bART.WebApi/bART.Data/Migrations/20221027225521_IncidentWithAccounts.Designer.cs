﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bART.Data.Context;

#nullable disable

namespace bART.Data.Migrations
{
    [DbContext(typeof(BartContext))]
    [Migration("20221027225521_IncidentWithAccounts")]
    partial class IncidentWithAccounts
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("bART.Data.Entities.Account", b =>
                {
                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IncidentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AccountName");

                    b.HasIndex("IncidentName");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("bART.Data.Entities.Incident", b =>
                {
                    b.Property<string>("IncidentName")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IncidentName");

                    b.ToTable("Incidents");
                });

            modelBuilder.Entity("bART.Data.Entities.Account", b =>
                {
                    b.HasOne("bART.Data.Entities.Incident", "Incident")
                        .WithMany("Accounts")
                        .HasForeignKey("IncidentName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incident");
                });

            modelBuilder.Entity("bART.Data.Entities.Incident", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
