using Microsoft.EntityFrameworkCore;
using StudingWizardPro.DataAccess.Entities;

namespace StudingWizardPro.DataAccess
{
    public class StudentWizardContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<AccessRight> AccessRights { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RoleAccessRight> RoleAccessRights { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<UserRole>()
                .HasKey(ur => new { ur.RoleID, ur.UserID });

            modelBuilder
                .Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserID);

            modelBuilder
                .Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleID);

            modelBuilder
                .Entity<RoleAccessRight>()
                .HasKey(rar => new { rar.RoleID, rar.AccessRightID });

            modelBuilder
                .Entity<RoleAccessRight>()
                .HasOne(rar => rar.Role)
                .WithMany(r => r.RoleAccessRights)
                .HasForeignKey(rar => rar.RoleID);

            modelBuilder
                .Entity<RoleAccessRight>()
                .HasOne(rar => rar.AccessRight)
                .WithMany(ar => ar.RoleAccessRights)
                .HasForeignKey(rar => rar.AccessRightID);
        }
    }
}
