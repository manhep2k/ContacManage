using Microsoft.EntityFrameworkCore;
using QLHĐSolotion.Data.Entity;
using QLHĐSolotion.Data.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace QLHĐSolotion.Data.EF
{ 
    public partial class testDbontext:IdentityDbContext<AppUser, AppRole, Guid>
    {
        public testDbontext (DbContextOptions options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        
        
        {
            

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
            modelBuilder.Seed();
        }
       
        //public virtual DbSet<Account> Accounts { get; set; }
        //public virtual DbSet<AppRole> Roles { get; set; }
        //public virtual DbSet<Credential> Credentials { get; set; }
        //public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<CtrDoiTac> CtrDoiTacs { get; set; }
        public virtual DbSet<CtrHopDong> CtrHopDongs { get; set; }
        public virtual DbSet<CtrKhachHang> CtrKhachHangs { get; set; }
        public virtual DbSet<CtrCongNo> CtrCongNos { get; set; }
    }
   

}
