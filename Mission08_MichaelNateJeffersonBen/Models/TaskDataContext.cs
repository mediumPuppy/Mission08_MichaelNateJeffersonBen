using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission08_MichaelNateJeffersonBen.Models;

public partial class TaskDataContext : DbContext
{
    public TaskDataContext()
    {
    }

    public TaskDataContext(DbContextOptions<TaskDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CategoryData> CategoryData { get; set; }

    public virtual DbSet<TaskData> TaskData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseSqlite("Data Source=TaskData.sqlite");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryData>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
        });

        modelBuilder.Entity<TaskData>(entity =>
        {
            entity.HasKey(e => e.TaskId);

            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Completed).HasDefaultValue(0);

            entity.HasOne(d => d.Category).WithMany(p => p.TaskData).HasForeignKey(d => d.CategoryId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
