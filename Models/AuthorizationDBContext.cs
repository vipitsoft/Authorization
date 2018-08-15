using Microsoft.EntityFrameworkCore;
using Models.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{

    public class AuthorizationDBContext : DbContext
    {
        public AuthorizationDBContext(DbContextOptions<AuthorizationDBContext> options) : base(options)
        {
        }

        public AuthorizationDBContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<RolePermissions> RolePermissions { get; set; }
        public DbSet<Permissions> Permissions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RolesConfiguration());
            modelBuilder.ApplyConfiguration(new RolePermissionsConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionsConfiguration());

            modelBuilder.Entity<User>().HasOne(t => t.Role).WithMany().HasForeignKey(t => t.RoleID);
        }
    }
}
