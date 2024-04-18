using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BeautyShop.Models;

namespace BeautyShop.Contexts
{
    public partial class BeautyShopDBContext : DbContext
    {
        public BeautyShopDBContext()
        {
        }

        public BeautyShopDBContext(DbContextOptions<BeautyShopDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeSchedule> EmployeeSchedules { get; set; } = null!;
        public virtual DbSet<Guestbook> Guestbooks { get; set; } = null!;
        public virtual DbSet<NamesService> NamesServices { get; set; } = null!;
        public virtual DbSet<RegistrationService> RegistrationServices { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<TypesService> TypesServices { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=Database/BeautyShopDB.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Clients_Id")
                    .IsUnique();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Employees_Id");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<EmployeeSchedule>(entity =>
            {
                entity.ToTable("EmployeeSchedule");

                entity.HasIndex(e => e.Id, "IX_EmployeeSchedule_Id")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Guestbook>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("Guestbook");

                entity.HasIndex(e => e.CommentId, "IX_Guestbook_CommentId")
                    .IsUnique();

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Guestbooks)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<NamesService>(entity =>
            {
                entity.HasKey(e => e.Name);
            });

            modelBuilder.Entity<RegistrationService>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_RegistrationServices_Id")
                    .IsUnique();

                entity.HasOne(d => d.ScheduleItem)
                    .WithMany(p => p.RegistrationServices)
                    .HasForeignKey(d => d.ScheduleItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasIndex(e => e.Id, "IX_Services_Id")
                    .IsUnique();

                entity.HasIndex(e => e.TypeService, "IX_Services_TypeService")
                    .IsUnique();

                entity.HasOne(d => d.NameNavigation)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.Name)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TypeServiceNavigation)
                    .WithOne(p => p.Service)
                    .HasForeignKey<Service>(d => d.TypeService)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TypesService>(entity =>
            {
                entity.HasKey(e => e.Name);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
