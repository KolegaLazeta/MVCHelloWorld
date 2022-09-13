using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EDMXFromDB
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<College_Students> College_Students { get; set; }
        public virtual DbSet<High_School_Students> High_School_Students { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<College_Students>()
                .Property(e => e.Name)
                .IsRequired();

            modelBuilder.Entity<College_Students>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<College_Students>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<College_Students>()
                .Property(e => e.Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<College_Students>()
                .Property(e => e.House_Address)
                .IsUnicode(false);

            modelBuilder.Entity<College_Students>()
                .Property(e => e.College_Name)
                .IsUnicode(false);

            modelBuilder.Entity<High_School_Students>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<High_School_Students>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<High_School_Students>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<High_School_Students>()
                .Property(e => e.Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<High_School_Students>()
                .Property(e => e.House_Address)
                .IsUnicode(false);

            modelBuilder.Entity<High_School_Students>()
                .Property(e => e.School_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Lastname)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.House_Address)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.School_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.College_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Type_of_Student)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
