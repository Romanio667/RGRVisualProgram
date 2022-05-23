using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RGR
{
    public partial class data_baseContext : DbContext
    {
        public data_baseContext()
        {
        }

        public data_baseContext(DbContextOptions<data_baseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<country> Countries { get; set; }
        public virtual DbSet<season> Season { get; set; }
        public virtual DbSet<player> Players { get; set; }
        public virtual DbSet<ground> Ground { get; set; }
        public virtual DbSet<team> Teams { get; set; }
        public virtual DbSet<trainer> Trainer { get; set; }
        public virtual DbSet<match> Match { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=C:\\Users\\Рома\\Desktop\\RGR\\data_base.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.countryId)
                    .ValueGeneratedNever()
                    .HasColumnName("countryId");

                entity.Property(e => e.countryName)
                    .HasColumnType("STRING")
                    .HasColumnName("countryName");
            });

            modelBuilder.Entity<season>(entity =>
            {
                entity.ToTable("season");

                entity.Property(e => e.seasonId)
                    .ValueGeneratedNever()
                    .HasColumnName("seasonId");

                entity.Property(e => e.seasonYear).HasColumnName("seasonYear");
            });

            modelBuilder.Entity<player>(entity =>
            {
                entity.ToTable("player");

                entity.Property(e => e.playerId)
                    .ValueGeneratedNever()
                    .HasColumnName("playerId");

                entity.Property(e => e.playerName)
                  .HasColumnType("STRING")
                  .HasColumnName("playerName");

                entity.Property(e => e.teamId).HasColumnName("teamId");            

                entity.Property(e => e.workExperience)
                    .HasColumnType("STRING")
                    .HasColumnName("workExperience");

                entity.Property(e => e.matches).HasColumnName("matches");

                entity.Property(e => e.runs).HasColumnName("runs");

                entity.HasOne(d => d.teamIdNavigation)
                   .WithMany(p => p.Players)
                   .HasForeignKey(d => d.teamId);

            });

            modelBuilder.Entity<ground>(entity =>
            {
                entity.ToTable("ground");

                entity.Property(e => e.groundId)
                .ValueGeneratedNever()
                .HasColumnName("groundId");

                entity.Property(e => e.groundName)
                  .HasColumnType("STRING")
                  .HasColumnName("groundName");

                entity.Property(e => e.countSeats).HasColumnName("countSeats");
            });

            modelBuilder.Entity<team>(entity =>
            {
                entity.ToTable("team");

                entity.Property(e => e.teamId)
                    .ValueGeneratedNever()
                    .HasColumnName("teamId");

                entity.Property(e => e.teamName)
                    .HasColumnType("STRING")
                    .HasColumnName("teamName");

                entity.Property(e => e.numberPlayers).HasColumnName("numberPlayers");

                entity.Property(e => e.countryId).HasColumnName("countryId");

                entity.Property(e => e.matchId).HasColumnName("matchId");

                entity.HasOne(d => d.countryIdNavigation)
                .WithMany()
                .HasForeignKey(d => d.countryId);

                entity.HasOne(d => d.matchIdNavigation)
                .WithMany(p => p.Teams)
                .HasForeignKey(d => d.matchId);

            });

            modelBuilder.Entity<trainer>(entity =>
            {
                entity.ToTable("trainer");

                entity.Property(e => e.trainerId)
                    .ValueGeneratedNever()
                    .HasColumnName("trainerId");

                entity.Property(e => e.name)
                    .HasColumnType("STRING")
                    .HasColumnName("name");

                entity.Property(e => e.workExperience)
                   .HasColumnType("STRING")
                   .HasColumnName("workExperience");

                entity.Property(e => e.teamId).HasColumnName("teamId");

                entity.HasOne(d => d.teamIdNavigation)
               .WithMany()
               .HasForeignKey(d => d.teamId);

            });

            modelBuilder.Entity<match>(entity =>
            {
                entity.ToTable("match");

                entity.Property(e => e.matchId)
                    .ValueGeneratedNever()
                    .HasColumnName("matchId");

               // entity.Property(e => e.firstTeamId).HasColumnName("firstTeamId");

                //entity.Property(e => e.secondTeamId).HasColumnName("secondTeamId");

               // entity.Property(e => e.countryId).HasColumnName("countryId");

                entity.Property(e => e.groundId).HasColumnName("groundId");

                entity.Property(e => e.result)
                    .HasColumnType("STRING")
                    .HasColumnName("result");

                entity.Property(e => e.date)
                    .HasColumnType("STRING")
                    .HasColumnName("date");

                entity.Property(e => e.seasonId).HasColumnName("seasonId");

               /* entity.HasOne(d => d.firstTeamIdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.firstTeamId);*/

                /*entity.HasOne(d => d.secondTeamIdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.secondTeamId);*/

                /*entity.HasOne(d => d.countryIdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.countryId);*/

                entity.HasOne(d => d.groundIdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.groundId);

                entity.HasOne(d => d.seasonIdNavigation)
                    .WithMany(p => p.Seasons)
                    .HasForeignKey(d => d.seasonId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
