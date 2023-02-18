using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RocWay.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocWay.Infrastructure.Data.EFCore
{
    public class RocWayContextFactory : IDesignTimeDbContextFactory<RocWayContext>
    {


        //public RocWayContext CreateDbContext(string[] args)
        //{
        //    var OptionBuilder = new DbContextOptionsBuilder<RocWayContext>();
        //    OptionBuilder.UseSqlServer("" +
        //        "Server=(localdb)\\mssqllocaldb;database=EFcoreCleanArqDB");
        //    return new RocWayContext(OptionBuilder.Options);
        //}

        //public RocWayContext CreateDbContext(string[] args)
        //{
        //    var OptionBuilder = new DbContextOptionsBuilder<RocWayContext>();
        //    OptionBuilder.UseNpgsql("Host=localhost;Port=5432;Username=RocWay_App_web;Password=RocWay@RocSoft2022;Database=RocWay;");
        //    return new RocWayContext(OptionBuilder.Options);
        //}

        public RocWayContext CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<RocWayContext>();
            OptionBuilder.UseNpgsql("Host=trumpet.db.elephantsql.com;Port=5432;Username=optrxonm;Password=Ybu5-17zvL1cpH6R3WubdUHyg89azsgA;Database=optrxonm");
            return new RocWayContext(OptionBuilder.Options);
        }
    }
}
