using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class StudentModel : DbContext
    {
        public StudentModel()
            : base("name=StudentModel1")
        {
        }

        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Major> Major { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Major)
                .WithRequired(e => e.Faculty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Faculty>()
                .HasMany(e => e.Student)
                .WithRequired(e => e.Faculty)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Major>()
                .HasMany(e => e.Student)
                .WithOptional(e => e.Major)
                .HasForeignKey(e => new { e.MajorID, e.FacultyID });

            modelBuilder.Entity<Student>()
                .Property(e => e.StudentID)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
