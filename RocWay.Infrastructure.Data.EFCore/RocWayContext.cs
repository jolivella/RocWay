using Microsoft.EntityFrameworkCore;
using RocWay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RocWay.Infrastructure.Data.EFCore
{
    public class RocWayContext:DbContext
    {
        public RocWayContext(DbContextOptions<RocWayContext> options) : base(options) { }
        public DbSet<Application> Applications { get; set; }
        public DbSet<AppRole> AppRoles { get;}
        public DbSet<AppRoleModule> AppRoleModules { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Module> Modules { get; set; } 
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAppRole> UserAppRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>()
                .HasKey(a=>a.AppId);
        }
    }
}
