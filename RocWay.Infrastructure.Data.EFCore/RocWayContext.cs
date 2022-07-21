using Microsoft.EntityFrameworkCore;
using RocWay.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RocWay.Infrastructure.Data.EFCore
{
    public class RocWayContext : DbContext
    {
        public RocWayContext(DbContextOptions<RocWayContext> options) : base(options) { }
        public DbSet<Application> Applications { get; set; }
        public DbSet<AppRole> AppRoles { get; }
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
            //Application
            modelBuilder.Entity<Application>()
                .HasKey(a => a.AppId);
            modelBuilder.Entity<Application>()
                .Property(a=>a.AppId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Application>()
                .Property(a => a.App)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Application>()
                .Property(a => a.ApiSubscriptionKey)
                .IsRequired()
                .HasMaxLength(36);
            modelBuilder.Entity<Application>()
                .Property(a => a.Active)
                .HasDefaultValue(true);

            //AppRole
            modelBuilder.Entity<AppRole>()
                .HasKey(ar => ar.AppRoleId);
            modelBuilder.Entity<AppRole>()
                .Property(ar => ar.AppRoleId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<AppRole>()
                .Property(ar => ar.Active)
                .HasDefaultValue(true);

            //AppRoleModule
            modelBuilder.Entity<AppRoleModule>()
                .HasKey(arm => arm.AppRoleModulesId);
            modelBuilder.Entity<AppRoleModule>()
                .Property(arm => arm.AppRoleModulesId)
                .ValueGeneratedOnAdd();

            //Configuration
            modelBuilder.Entity<Configuration>()
                .HasKey(c => c.ConfigurationId);
            modelBuilder.Entity<Configuration>()
                .Property(arm => arm.ConfigurationId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Configuration>()
                .Property(c => c.StringConecction)
                .HasMaxLength(2000);
                
            //Contract
            modelBuilder.Entity<Contract>()
                .HasKey(c => c.ContractId);
            modelBuilder.Entity<Contract>()
                .Property(c => c.ContractId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Contract>()
                .Property(c => c.ContractType)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Contract>()
                .Property(c => c.ContractValidity)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Contract>()
                .Property(c => c.ContractStartDate)
                .IsRequired()
                .HasColumnType("Date");
            modelBuilder.Entity<Contract>()
                .Property(c => c.ExpirationDate)
                .IsRequired()
                .HasColumnType("Date");
            modelBuilder.Entity<Contract>()
                .Property(c => c.Active)
                .HasDefaultValue(true);

            //Customer
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.CustomerId);
            modelBuilder.Entity<Customer>()
               .Property(c => c.CustomerId)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Customer>()
                .Property(c => c.Nit)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
                .Property(c => c.RegimenType)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<Customer>()
               .Property(c => c.CompanyName)
               .IsRequired()
               .HasMaxLength(250);
            modelBuilder.Entity<Customer>()
               .Property(c => c.Location)
               .IsRequired()
               .HasMaxLength(100);
            modelBuilder.Entity<Customer>()
               .Property(c => c.ContactName)
               .IsRequired()
               .HasMaxLength(250);
            modelBuilder.Entity<Customer>()
               .Property(c => c.Phone)
               .IsRequired()
               .HasMaxLength(25);
            modelBuilder.Entity<Customer>()
               .Property(c => c.Email)
               .IsRequired()
               .HasMaxLength(100);
            modelBuilder.Entity<Customer>()
               .Property(c => c.Logo)
               .IsRequired()
               .HasMaxLength(1000);

            //Module
            modelBuilder.Entity<Module>()
                .HasKey(m => m.ModuleId);
            modelBuilder.Entity<Module>()
               .Property(m => m.ModuleId)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Module>()
                .Property(m => m.Url)
                .HasMaxLength(250);
            modelBuilder.Entity<Module>()
                .Property(m => m.Active)
                .HasDefaultValue(true);

            //Payment
            modelBuilder.Entity<Payment>()
                .HasKey(m => m.PaymentId);
            modelBuilder.Entity<Payment>()
               .Property(p => p.PaymentId)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Payment>()
                .Property(m => m.PaymentDate)
                .IsRequired()
                .HasColumnType("date");
            modelBuilder.Entity<Payment>()
                .Property(m => m.PaidPeriod)
                .HasMaxLength(4);

            //Permission
            modelBuilder.Entity<Permission>()
                .HasKey(m => m.PermissionId);
            modelBuilder.Entity<Permission>()
               .Property(p => p.PermissionId)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Permission>()
                .Property(m => m.PermissionName)
                .IsRequired()
                .HasMaxLength(250);
            modelBuilder.Entity<Permission>()
                .Property(m => m.Active)
                .HasDefaultValue(true);

            //Role
            modelBuilder.Entity<Role>()
                .HasKey(m => m.RoleId);
            modelBuilder.Entity<Role>()
               .Property(r => r.RoleId)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<Role>()
                .Property(m => m.RoleName)
                .IsRequired()
                .HasMaxLength(250);
            modelBuilder.Entity<Role>()
                .Property(m => m.Active)
                .HasDefaultValue(true);

            //User
            modelBuilder.Entity<User>()
                .HasKey(m => m.UserId);
            modelBuilder.Entity<User>()
               .Property(u => u.UserId)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<User>()
                .Property(m => m.CompleteName)
                .IsRequired()
                .HasMaxLength(250);
            modelBuilder.Entity<User>()
                .Property(m => m.UserName)
                .IsRequired()
                .HasMaxLength(250);
            modelBuilder.Entity<User>()
                .Property(m => m.Password)
                .IsRequired()
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(m => m.Active)
                .HasDefaultValue(true);

            //UserAppRole
            modelBuilder.Entity<UserAppRole>()
               .HasKey(m => m.UserAppRoleId);
            modelBuilder.Entity<UserAppRole>()
               .Property(c => c.UserAppRoleId)
               .ValueGeneratedOnAdd();
            modelBuilder.Entity<UserAppRole>()
                .Property(m => m.Active)
                .HasDefaultValue(true);


            //Relations
            modelBuilder.Entity<AppRole>()
                .HasOne<Application>()
                .WithMany()
                .HasForeignKey(ar => ar.AppId);
            modelBuilder.Entity<AppRole>()
                .HasOne<Role>()
                .WithMany()
                .HasForeignKey(ar => ar.RoleId);

            modelBuilder.Entity<AppRoleModule>()
               .HasOne<AppRole>()
               .WithMany()
               .HasForeignKey(arm => arm.AppRoleId);
            modelBuilder.Entity<AppRoleModule>()
               .HasOne<Module>()
               .WithMany()
               .HasForeignKey(arm => arm.ModuleId);
            modelBuilder.Entity<AppRoleModule>()
               .HasOne<Permission>()
               .WithMany()
               .HasForeignKey(arm => arm.PermissionId);

            modelBuilder.Entity<Configuration>()
                .HasOne<Contract>()
                .WithMany()
                .HasForeignKey(c => c.ContractId);

            modelBuilder.Entity<Contract>()
                .HasOne<Application>()
                .WithMany()
                .HasForeignKey(c => c.AppId);

            modelBuilder.Entity<Contract>()
                .HasOne<Customer>()
                .WithMany()
                .HasForeignKey(c => c.AppId);

            modelBuilder.Entity<Module>()
                .HasOne<Application>()
                .WithMany()
                .HasForeignKey(m => m.AppId);

            modelBuilder.Entity<Payment>()
                .HasOne<Contract>()
                .WithMany()
                .HasForeignKey(p => p.ContractId);

            modelBuilder.Entity<User>()
                .HasOne<Contract>()
                .WithMany()
                .HasForeignKey(p => p.ContractId);

            modelBuilder.Entity<UserAppRole>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(uar => uar.UserId);
            modelBuilder.Entity<UserAppRole>()
                .HasOne<AppRole>()
                .WithMany()
                .HasForeignKey(uar => uar.AppRoleId);

        }


    }
}
