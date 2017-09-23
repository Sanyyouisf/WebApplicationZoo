using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplicationZoo.Models;

namespace WebApplicationZoo.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext () : base("WebAppZoo")
        { }
        public DbSet <Animals> Animal { get; set; }
        public DbSet <Environments> Enviroenvironment { get; set; }
        public DbSet<ZooKeepers> Zookeeper { get; set; }

    }
}