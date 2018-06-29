﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Salon.EF;
using System;

namespace Salon.EF.Migrations
{
    [DbContext(typeof(SalonContext))]
    [Migration("20180511213932_changeField")]
    partial class changeField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Salon.EF.Class", b =>
                {
                    b.Property<int>("ClassID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Fri");

                    b.Property<decimal?>("IndividualCost");

                    b.Property<bool>("Mon");

                    b.Property<decimal?>("MounthCost");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("Sat");

                    b.Property<string>("Schedule");

                    b.Property<bool>("Sun");

                    b.Property<int?>("TeacherID");

                    b.Property<bool>("Thu");

                    b.Property<decimal?>("TotalCost");

                    b.Property<bool>("Tue");

                    b.Property<int>("TypeClass");

                    b.Property<bool>("Wen");

                    b.HasKey("ClassID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("Salon.EF.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("Cost");

                    b.Property<decimal?>("CostTotal");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("PromotionID");

                    b.Property<DateTime>("Register");

                    b.Property<int>("TypeCost");

                    b.HasKey("PaymentID");

                    b.HasIndex("PromotionID");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Salon.EF.Promotion", b =>
                {
                    b.Property<int>("PromotionID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Cost");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Percent");

                    b.Property<DateTime>("Register");

                    b.Property<DateTime>("Until");

                    b.HasKey("PromotionID");

                    b.ToTable("Promotion");
                });

            modelBuilder.Entity("Salon.EF.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("From");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Phone");

                    b.Property<string>("Register");

                    b.Property<string>("TypePublicity");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Salon.EF.Subscription", b =>
                {
                    b.Property<int>("SubscriptionID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassID");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("Register");

                    b.Property<int>("StudenID");

                    b.HasKey("SubscriptionID");

                    b.HasIndex("ClassID");

                    b.HasIndex("StudenID");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Salon.EF.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Phone");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Salon.EF.Class", b =>
                {
                    b.HasOne("Salon.EF.Teacher")
                        .WithMany("Classes")
                        .HasForeignKey("TeacherID");
                });

            modelBuilder.Entity("Salon.EF.Payment", b =>
                {
                    b.HasOne("Salon.EF.Promotion", "Promotion")
                        .WithMany()
                        .HasForeignKey("PromotionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Salon.EF.Subscription", b =>
                {
                    b.HasOne("Salon.EF.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Salon.EF.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudenID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
