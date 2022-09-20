using BusinessObjectModel;
using System.Data.Entity;

namespace DataAccess
{
    public class TuxContext : DbContext
    {
        public DbSet<College> College { get; set; }
        public DbSet<HighSchool> HighSchool { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
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

            modelBuilder.Entity<Users>()
                .HasMany<Roles>(s => s.Roles)
                .WithMany(c => c.Users)
                .Map(cs =>
                {
                    cs.MapLeftKey("UsersRefId");
                    cs.MapRightKey("RolesRefId");
                    cs.ToTable("UserRoles");
                });

            Database.SetInitializer<TuxContext>(null);
            base.OnModelCreating(modelBuilder);

        }



    }
}
