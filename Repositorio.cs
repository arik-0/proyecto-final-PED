using proyecto_final_PED.proyecto_final_PED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyecto_final_PED
{
    public class Repositorio
    {
        private List<Rubro> rubros;
        private List<Producto> productos;
        private List<Proveedor> proveedores;
        private List<MovimientoStock> movimientosStock;
        
        public Repositorio()
        {
            rubros = ArchivoManager.CargarRubros();
            productos = ArchivoManager.CargarProductos(rubros);
            proveedores = ArchivoManager.CargarProveedores();
            movimientosStock = ArchivoManager.CargarMovimientos(productos, proveedores);
        }

        public List<Rubro> ObtenerRubros() => rubros;
        public List<Producto> ObtenerProductos() => productos;
        public List<Proveedor> ObtenerProveedores() => proveedores;
        public List<MovimientoStock> ObtenerMovimientos() => movimientosStock;
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
        public void ModificarRubro(Rubro rubroModificado)
        {
            var rubroExistente = rubros.FirstOrDefault(r => r.Nombre == rubroModificado.Nombre);
            if (rubroExistente == null)
                throw new ArgumentException("El rubro a modificar no existe.");

            rubroExistente.Descripcion = rubroModificado.Descripcion;

            ArchivoManager.GuardarRubros(rubros);
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
                ArchivoManager.GuardarProductos(productos);
            }
        }
        //Operaciones de proveedor
        public void AgregarProveedor(Proveedor p)
        {
            proveedores.Add(p);
            ArchivoManager.GuardarProveedores(proveedores);
        }
        public void EliminarProveedor(Guid id)
        {
            proveedores.RemoveAll(p => p.Id == id);
            ArchivoManager.GuardarProveedores(proveedores);
        }
        public void ModificarProveedor(Proveedor proveedorModificado)
        {
            var p = proveedores.FirstOrDefault(x => x.Id == proveedorModificado.Id);
            if (p != null)
            {
                p.Nombre = proveedorModificado.Nombre;
                p.Contacto = proveedorModificado.Contacto;
                p.Telefono = proveedorModificado.Telefono;
                p.Direccion = proveedorModificado.Direccion;
                ArchivoManager.GuardarProveedores(proveedores);
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
        //Operaciones con Movimientos
        public void AgregarMovimiento(MovimientoStock r)
        { 
            if(r is EgresoStock egreso) { r.Cantidad = -egreso.Cantidad; }
            movimientosStock.Add(r);
           
            ArchivoManager.GuardarMovimientos(movimientosStock);
            ActualizarStock(r.Cantidad, r.Producto.Codigo);
        }
        public void ActualizarStock(int productosEntrantes, int idProducto)
        {
            Producto productoEntrante = productos.FirstOrDefault(p => p.Codigo == idProducto);
            productoEntrante.Stock = productoEntrante.Stock + productosEntrantes;
            ModificarProducto(productoEntrante);
        }

        public List<Producto> BuscarProductoPorNombre(string nombre)
        {
            return productos
                .Where(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                .ToList(); 
        }
        public List<Producto> BuscarProductosPorNombreDeRubro(string nombreRubro)
        {
            return productos
                .Where(p => p.Rubro != null &&
                            p.Rubro.Nombre.Equals(nombreRubro, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public List<Proveedor> BuscarProveedorPorNombre(string nombre)
        {
            return proveedores
                .Where(p => p.Nombre != null &&
                            p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
        public List<MovimientoStock> BuscarMovimientosPorNombreProducto(string nombre)
        {
            return movimientosStock
                .Where(m => m.Producto.Nombre != null &&
                            m.Producto.Nombre.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }
        public void DescontarStockDeProductosVencidos()
        {
            DateTime hoy = DateTime.Today;

            var ingresosVencidos = movimientosStock
                .OfType<IngresoStock>()
                .Where(m => m.FechaVencimiento < hoy)
                .ToList();

            foreach (var ingreso in ingresosVencidos)
            {
                // Verificamos cuánto stock queda para ese lote
                int stockDisponibleDelLote = movimientosStock
                    .Where(m => m.Producto.Codigo == ingreso.Producto.Codigo &&
                                m is IngresoStock i && i.FechaVencimiento == ingreso.FechaVencimiento)
                    .Sum(m => m.Cantidad);

                if (stockDisponibleDelLote > 0)
                {
                    // Creamos egreso automático por vencimiento
                    var egresoVencido = new EgresoStock
                    {
                        Producto = ingreso.Producto,
                        Cantidad = stockDisponibleDelLote,
                        Observacion = "Descontado automáticamente por vencimiento",
                        Fecha = DateTime.Now
                    };

                    movimientosStock.Add(egresoVencido);
                }
            }

            ArchivoManager.GuardarMovimientos(movimientosStock);
        }


    }
}
