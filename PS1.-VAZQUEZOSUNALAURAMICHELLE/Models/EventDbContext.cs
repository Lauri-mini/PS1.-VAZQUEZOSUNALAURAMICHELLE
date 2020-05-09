using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PS1._VAZQUEZOSUNALAURAMICHELLE.Models
{
    public class EventDbContext : DbContext
    {
        public EventDbContext() : base("LAURITADB")
        {

        }
        public DbSet <Event> Events {get; set;}
        public DbSet <City> Cities { get; set; }
    }
}