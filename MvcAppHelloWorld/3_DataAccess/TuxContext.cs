using BusinessObjectModel;
using System.Data.Entity;

namespace DataAccess
{
    public class TuxContext : DbContext
    {
        public DbSet<College> College { get; set; }
        public DbSet<HighSchool> HighSchool { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Admin> Admin { get; set; }

        public TuxContext() : base("name=TuxDatabase")
        {
            Configuration.LazyLoadingEnabled = true;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<UserRole>().ToTable("UserRole");


            modelBuilder.Entity<Professor>()
                .Map<Professor>(m => m.Requires("TypeOfUser").HasValue("Professor"));

            modelBuilder.Entity<HighSchool>()
                .Map<HighSchool>(m => m.Requires("TypeOfUser").HasValue("HighSchool"));

            modelBuilder.Entity<College>()
                .Map<College>(m => m.Requires("TypeOfUser").HasValue("College"));

            modelBuilder.Entity<Admin>()
                .Map<Admin>(m => m.Requires("TypeOfUser").HasValue("Admin"));



            //// Many to many relationship
            //modelBuilder.Entity<Users>()
            //    .HasMany<Role>(s => s.Role)
            //    .WithMany(c => c.Users)
            //    .Map(cs =>
            //    {
            //        cs.MapLeftKey("UserRefId");
            //        cs.MapRightKey("RoleRefId");
            //        cs.ToTable("UserRole");
            //    });

            modelBuilder.Entity<UserRole>()
                .HasKey(c => new { c.UserId, c.RoleId });



            modelBuilder.Entity<Users>()
                 .HasMany(c => c.UserRole)
                 .WithRequired()
                 .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Role>()
                 .HasMany(c => c.UserRole)
                 .WithRequired()
                 .HasForeignKey(c => c.RoleId);

            Database.SetInitializer<TuxContext>(null);

        }



    }
}
