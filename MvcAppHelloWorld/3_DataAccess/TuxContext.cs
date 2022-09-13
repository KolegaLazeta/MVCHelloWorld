using System.Data.Entity;
using BusinessObjectModel;
using BusinessObjectModel;
using BusinessObjectModel;

namespace DataAccess
{
    public class TuxContext : DbContext
    {
        public DbSet<College> College { get; set; }
        public DbSet<HighSchool> HighSchool { get; set; }
        public DbSet<Students> Students { get; set; }
        public TuxContext() : base("name=TuxDatabase") 
        {
            Configuration.LazyLoadingEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().ToTable("Students");

            modelBuilder.Entity<HighSchool>()

                .Map<HighSchool>(m => m.Requires("Type_of_Student").HasValue(1));

            modelBuilder.Entity<College>()

                .Map<College>(m => m.Requires("Type_of_Student").HasValue(2));

        }
    }
}
