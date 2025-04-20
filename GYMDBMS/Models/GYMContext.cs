using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GYMDBMS.Models
{
    public partial class GYMContext : DbContext
    {
        public GYMContext()
        {
        }

        public GYMContext(DbContextOptions<GYMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Exercise> Exercises { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;
        public virtual DbSet<NutritionPlan> NutritionPlans { get; set; } = null!;
        public virtual DbSet<Trainer> Trainers { get; set; } = null!;
        public virtual DbSet<Workout> Workouts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#pragma warning disable CS1030 // #warning directive
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-TOLK440J\\MSSQLSERVER03;Database=GYM;User id=sa;password=2829;");
#pragma warning restore CS1030 // #warning directive
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => new { e.ClientId, e.TrainerId });

                entity.Property(e => e.ClientId)
                    .HasMaxLength(50)
                    .HasColumnName("ClientID");

                entity.Property(e => e.TrainerId)
                    .HasMaxLength(50)
                    .HasColumnName("TrainerID");

                entity.Property(e => e.ContactNumer).HasMaxLength(50);

                entity.Property(e => e.FitnessGoal).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.TrainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clients_Trainers");
            });

            modelBuilder.Entity<Exercise>(entity =>
            {
                entity.Property(e => e.ExerciseId)
                    .HasMaxLength(50)
                    .HasColumnName("ExerciseID");

                entity.Property(e => e.Instruction).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.ToTable("FOODS");

                entity.Property(e => e.FoodId)
                    .HasMaxLength(50)
                    .HasColumnName("FoodID");

                entity.Property(e => e.Calories).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Protien).HasMaxLength(50);
            });

            modelBuilder.Entity<NutritionPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("NUTRITION PLAN");

                entity.Property(e => e.PlanId)
                    .HasMaxLength(50)
                    .HasColumnName("PlanID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.Property(e => e.TrainerId)
                    .HasMaxLength(50)
                    .HasColumnName("TrainerID");

                entity.Property(e => e.ContactNumber).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specialty).HasMaxLength(50);
            });

            modelBuilder.Entity<Workout>(entity =>
            {
                entity.Property(e => e.WorkoutId)
                    .HasMaxLength(50)
                    .HasColumnName("WorkoutID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
