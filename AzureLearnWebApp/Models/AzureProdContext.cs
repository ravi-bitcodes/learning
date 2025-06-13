using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AzureLearnWebApp.Models;

public partial class AzureProdContext : DbContext
{
    public AzureProdContext()
    {
    }

    public AzureProdContext(DbContextOptions<AzureProdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseAuthor> CourseAuthors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:azure-learning-prod.database.windows.net,1433;Initial Catalog=uat-azurelearning;Persist Security Info=False;User ID=bitcodes;Password=Nimda@6266;Encrypt=True;TrustServerCertificate=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC27DAA713AC");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.ACode)
                .HasMaxLength(10)
                .HasColumnName("a_code");
            entity.Property(e => e.AEmail)
                .HasMaxLength(100)
                .HasColumnName("a_email");
            entity.Property(e => e.ALastName)
                .HasMaxLength(50)
                .HasColumnName("a_last_name");
            entity.Property(e => e.AName)
                .HasMaxLength(100)
                .HasColumnName("a_name");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Courses__3214EC27770E6A66");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.CCode)
                .HasMaxLength(10)
                .HasColumnName("c_code");
            entity.Property(e => e.CName)
                .HasMaxLength(100)
                .HasColumnName("c_name");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasColumnName("is_active");
        });

        modelBuilder.Entity<CourseAuthor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CourseAu__3214EC070F84F469");

            entity.ToTable("CourseAuthor");

            entity.Property(e => e.AuthorId).HasColumnName("author_id");
            entity.Property(e => e.CourceId).HasColumnName("cource_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
