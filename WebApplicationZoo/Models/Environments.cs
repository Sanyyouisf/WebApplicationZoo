using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationZoo.Models
{
    public class Environments
    {
        public int Id { get; set; }
        public string EnclosureName { get; set; }
        public EnclosureType Type { get; set; }
        public bool outdoor { get; set; }
        public virtual List<Animals> Animals { get; set; }
       
    }

    public enum EnclosureType
    {
        Cage,
        fence,
        Pool
    }
}