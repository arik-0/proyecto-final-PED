using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyecto_final_PED
{
    public class Repositorio
    {
        private List<Rubro> rubros;
        private List<Producto> productos;

        public Repositorio()
        {
            rubros = ArchivoManager.CargarRubros();
            productos = ArchivoManager.CargarProductos(rubros);
        }

        public List<Rubro> ObtenerRubros() => rubros;
        public List<Producto> ObtenerProductos() => productos;

        //Operaciones de Producto
        public void AgregarProducto(Producto p)
        {
            productos.Add(p);
            ArchivoManager.GuardarProductos(productos);
        }
        public void EliminarProducto(int codigo)
        {
            productos.RemoveAll(p => p.Codigo == codigo);
            ArchivoManager.GuardarProductos(productos);
        }
        public void ModificarProducto(Producto productoModificado)
        {
            var p = productos.FirstOrDefault(x => x.Codigo == productoModificado.Codigo);
            if (p != null)
            {
                p.Nombre = productoModificado.Nombre;
                p.Descripcion = productoModificado.Descripcion;
                p.PrecioCompra = productoModificado.PrecioCompra;
                p.Stock = productoModificado.Stock;
                p.Rubro = productoModificado.Rubro;
                p.FechaVencimiento = productoModificado.FechaVencimiento;
                ArchivoManager.GuardarProductos(productos);
            }
        }

        //Operaciones de Rubro
        public void AgregarRubro(Rubro r)
        {
            rubros.Add(r);
            ArchivoManager.GuardarRubros(rubros);
        }
        public void EliminarRubro(string nombre)
        {
            rubros.RemoveAll(p => p.Nombre == nombre);
            ArchivoManager.GuardarRubros(rubros);
        }
        public List<Producto> BuscarProductoPorNombre(string nombre)
        {
            return productos
                .Where(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                .ToList(); 
        }
    }
}
