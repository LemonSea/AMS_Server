using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace AMS.Model
{
    public class CoreDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=XX_AMS;Integrated Security=True");
        //    }
        //}

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options) 
        { }

        public virtual DbSet<RoleModel> T_Role { get; set; }
    }
}
