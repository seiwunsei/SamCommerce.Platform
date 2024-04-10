﻿using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCommerce.Platform.Data.Infrastructure
{
    /// <summary>
    /// A <see cref="DbContextWithTriggers"/> derived class with UtcDateTimeConverter for all DateTime properties. 
    /// </summary>
    public class DbContextBase : DbContextWithTriggers
    {
        public DbContextBase()
        {
        }

        public DbContextBase(IServiceProvider serviceProvider) :
            base(serviceProvider)
        {
        }

        public DbContextBase(DbContextOptions options)
            : base(options)
        {
        }

        public DbContextBase(IServiceProvider serviceProvider, DbContextOptions options)
            : base(serviceProvider, options)
        {
        }


        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<DateTime>().HaveConversion<UtcDateTimeConverter>();
        }
    }
}