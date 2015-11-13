using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectofinal.mibd
{
    public class index : DbContext
    {
        public DbSet<classejemplo> classejemplos { get; set; }
    }
}
