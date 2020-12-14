using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PrizesService.Models.DBModels
{
    public partial class prizesserviceContext : DbContext
    {
        public prizesserviceContext()
        {
        }

        public prizesserviceContext(DbContextOptions<prizesserviceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Nationalities> Nationalities { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersNationalities> UsersNationalities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nationalities>(entity =>
            {
                entity.HasKey(e => e.NationalityId)
                    .HasName("PRIMARY");

                entity.ToTable("nationalities");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("users");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(40)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<UsersNationalities>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("users_nationalities");

                entity.HasIndex(e => e.NationalityId)
                    .HasName("nationality_id");

                entity.HasIndex(e => e.UserId)
                    .HasName("user_id");

                entity.Property(e => e.NationalityId).HasColumnName("nationality_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Nationality)
                    .WithMany()
                    .HasForeignKey(d => d.NationalityId)
                    .HasConstraintName("users_nationalities_ibfk_2");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("users_nationalities_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
