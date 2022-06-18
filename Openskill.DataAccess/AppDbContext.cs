using Friendly.DataAccess.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Openskill.DataAccess.Seeds;
using Openskill.Domain.Entities;

namespace Openskill.DataAccess
{
    public class AppDbContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<TrackModule> TrackModules { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        /// <summary>
        /// Database seed.
        /// </summary>
        /// <param name="builder">Model builder.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Configuration section.
            builder.ApplyConfiguration(new UserRoleEntityConfiguration());
            builder.ApplyConfiguration(new TrackModuleEntityConfiguration());

            // Execute database seed.
            DatabaseSeed.Execute(builder);
        }
    }
}
