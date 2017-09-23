using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationZoo.Models
{
    public class Animals
    {
        public int Id { get; set; }
        public string AnimalName { get; set; }
        public virtual ZooKeepers ZooKeeperId { get; set; }
        public virtual Environments EnclosureId { get; set; }
        public AnimalClass Class { get; set; }
        public AnimalSpecies Species { get; set; }
        public bool Dangerous { get; set; }
    }

    

    public enum AnimalSpecies
    {
        lion,
        tiger,
        Falcon,
        Elephant,
        Zebra,
        turtle,
        horse,

    }

    public enum AnimalClass
    {       
        Reptiles,
        Birds,
        Mammals,
        Amphibians,
        fish
    }
}