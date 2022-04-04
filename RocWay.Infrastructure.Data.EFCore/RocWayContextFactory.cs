﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
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

        public RocWayContext CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<RocWayContext>();
            OptionBuilder.UseNpgsql("Host=localhost;Port=5432;Username=RocWay_App_web;Password=RocWay@RocSoft2022;Database=RocWay;");
            return new RocWayContext(OptionBuilder.Options);
        }
    }
}