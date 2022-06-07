using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PANME.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public ProductosBL()
        {

            _contexto = new Contexto();
        }

        public List<Producto> ObtenerProductos()
        {
                        
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Bolsa de Pan Molde";
            producto1.Precio = 65;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "Bolsa de Pan Blanco";
            producto2.Precio = 35;


            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Dulces de Leche";
            producto3.Precio = 25;

           var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return listadeProductos;
        }
    }
}
