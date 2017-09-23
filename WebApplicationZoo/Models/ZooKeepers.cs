using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationZoo.Models
{
    public class ZooKeepers
    {
        public int Id { get; set; }
        public string ZooKeeperName { get; set; }
        public virtual List<Animals> Animals{get; set;}
        public DateTime HireDate { get; set; }
        public bool Certified { get; set; }
    }
}