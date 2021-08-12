using Microsoft.EntityFrameworkCore;
using Social.Network.Domain.Models;

/**
* @author HariLab
* @date - 8/11/2021 12:15:35 AM 
*/

namespace Social.Network.Data.Contexts
{
    public partial class SocialNetworkContext : DbContext
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public SocialNetworkContext()
        {
                
        }

        public SocialNetworkContext(DbContextOptions<SocialNetworkContext> options) 
            : base(options)
        {
                
        }

        public virtual DbSet<Channels> Channels { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }
        public virtual DbSet<People> People { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Channels>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID").ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                .HasColumnName("Name")
                .HasMaxLength(150);

                entity.Property(e => e.Description).HasMaxLength(350);

            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID").ValueGeneratedOnAdd();

                entity.Property(e => e.UserId).HasColumnName("UserId");

                entity.Property(e => e.Title)
                .HasColumnName("Title")
                .HasMaxLength(150);

                entity.Property(e => e.Description).HasMaxLength(350);

            });

            modelBuilder.Entity<Videos>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID").ValueGeneratedOnAdd();

                entity.Property(e => e.UserId).HasColumnName("UserId");

                entity.Property(e => e.Title)
                .HasColumnName("Title")
                .HasMaxLength(150);

                entity.Property(e => e.Duration).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(350);

            });

            modelBuilder.Entity<Activities>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID").ValueGeneratedOnAdd();

                entity.Property(e => e.Activity)
                .HasColumnName("Activity")
                .HasMaxLength(150);

                entity.Property(e => e.Description).HasMaxLength(350);

                entity.Property(e => e.Date).HasColumnType("datetime");

            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.Property(e => e.ID).HasColumnName("ID").ValueGeneratedOnAdd();

                entity.Property(e => e.UserId).HasColumnName("UserId");


            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
