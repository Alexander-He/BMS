using BMS.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.AppData
{
    class BMSContext : DbContext
    {
        public BMSContext() : base("BMSdb")
        {   

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<PropertyMetadata> PropertyMetadatas { get; set; } 
    }
}
