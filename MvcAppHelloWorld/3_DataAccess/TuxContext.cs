using BusinessObjectModel;
using System.Data.Entity;

namespace DataAccess
{
    public class TuxContext : DbContext
    {
        public DbSet<College> College { get; set; }
        public DbSet<HighSchool> HighSchool { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        //public DbSet<UserRole> UserRole { get; set; }
        public TuxContext() : base("name=TuxDatabase")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { 


            modelBuilder.Entity<HighSchool>()
                .Map<HighSchool>(m => m.Requires("RoleId").HasValue(1));
            modelBuilder.Entity<College>()
                .Map<College>(m => m.Requires("RoleId").HasValue(2));

            modelBuilder.Entity<User>()
                .HasMany<Role>(s => s.Roles)
                .WithMany(c => c.Users)
                .Map(cs =>
                {
                    cs.MapLeftKey("UserRefId");
                    cs.MapRightKey("RoleRefId");
                    cs.ToTable("UserRole");
                });

            Database.SetInitializer<TuxContext>(null);
            base.OnModelCreating(modelBuilder);

        }



    }
}
