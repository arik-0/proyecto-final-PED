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

        public void AgregarProducto(Producto p)
        {
            productos.Add(p);
            ArchivoManager.GuardarProductos(productos);
        }

        public void AgregarRubro(Rubro r)
        {
            rubros.Add(r);
            ArchivoManager.GuardarRubros(rubros);
        }
        /*public void Auxiliar()
        {
             Rubro r1 = new Rubro();
             r1.Nombre = "Electrónica";
             r1.Descripcion = "Productos electrónicos";
             Rubros.Add(r1);
        }*/
       
       /*public void AgregarProducto(string nombre, string descripcion, int stock,DateTime fechaVto,float precioCompra,Rubro rubroSeleccionado)
       {
            if (rubroSeleccionado == null)
            {
                MessageBox.Show("No se puede agregar producto sin un rubro válido.");
                return;
            }
            Producto nuevoProd = new();
            nuevoProd.Rubro = rubroSeleccionado;
            nuevoProd.Nombre = nombre;
            nuevoProd.Descripcion = descripcion;
            nuevoProd.FechaVencimiento = fechaVto;
            nuevoProd.PrecioCompra = precioCompra;
            nuevoProd.Stock = stock;
            AgregarProducto(nuevoProd);

       }*/
    }
}
