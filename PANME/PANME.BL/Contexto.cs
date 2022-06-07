using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PANME.BL
{
    public class Contexto: DbContext
    {
        public Contexto(): base("PANMEDB") 
        {

        }

        public DbSet<Producto> Productos { get; set; }
    }
}
