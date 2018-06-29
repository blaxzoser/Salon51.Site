using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.EF
{
    public class SalonContext : DbContext
    {
        public DbSet<Student> Studens { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Payment> Payments { get; set; }


        public SalonContext(DbContextOptions<SalonContext> options)
        : base(options)
        { }

        public SalonContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=Salon51Db;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student")
                .HasIndex(source => source.Name)
                .IsUnique()
                ;
            modelBuilder.Entity<Class>().ToTable("Class");

            modelBuilder.Entity<Teacher>()
            .HasMany(p => p.Classes);


            modelBuilder.Entity<Subscription>()
            .HasOne(source => source.Student)
            ;

            modelBuilder.Entity<Subscription>()
            .HasOne(source => source.Class)
            ;

            modelBuilder.Entity<Promotion>().ToTable("Promotion");
            modelBuilder.Entity<Payment>().ToTable("Payment")
                .HasOne(source => source.Promotion);
        }
    }
}
