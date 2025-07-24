using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace proyecto_final_PED
{
    public class ImpresoraGenerica
    {
        private readonly string carpeta;

        public ImpresoraGenerica()
        {
            // Ruta relativa a la carpeta bin (ej: bin\Debug\net8.0\Reportes)
            carpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reportes");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);
        }

        public void ImprimirStockPorProducto(List<Producto> productos)
        {
            string path = Path.Combine(carpeta, "StockPorProducto.txt");
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("REPORTE: Stock Actual por Producto");
                sw.WriteLine("Fecha: " + DateTime.Now);
                sw.WriteLine("--------------------------------------------");
                foreach (var p in productos)
                    sw.WriteLine($"Código: {p.Codigo} | Nombre: {p.Nombre} | Stock: {p.Stock}");
            }
        }
        public void ImprimirProductosConBajoStock(List<Producto> productos, int umbral)
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "reportes", "ProductosConBajoStock.txt");

            using (StreamWriter sw = new StreamWriter(ruta, false))
            {
                sw.WriteLine($"REPORTE: Productos con stock menor a {umbral}");
                sw.WriteLine($"Generado: {DateTime.Now:dd/MM/yyyy HH:mm}");
                sw.WriteLine(new string('-', 50));

                foreach (var p in productos)
                {
                    sw.WriteLine($"Código: {p.Codigo} | Nombre: {p.Nombre} | Stock: {p.Stock}");
                }
            }
        }


        public void ImprimirStockPorRubro(List<Producto> productos, List<Rubro> rubros)
        {
            string path = Path.Combine(carpeta, "StockPorRubro.txt");
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("REPORTE: Stock por Rubro");
                sw.WriteLine("Fecha: " + DateTime.Now);
                sw.WriteLine("--------------------------------------------");

                foreach (var rubro in rubros)
                {
                    int stockTotal = productos
                        .Where(p => p.Rubro != null && p.Rubro.Nombre == rubro.Nombre)
                        .Sum(p => p.Stock);

                    sw.WriteLine($"Rubro: {rubro.Nombre} | Stock Total: {stockTotal}");
                }
            }
        }

        public void ImprimirMovimientosPorProveedor(List<IngresoStock> ingresos)
        {
            string path = Path.Combine(carpeta, "MovimientosPorProveedor.txt");
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("REPORTE: Movimientos por Proveedor");
                sw.WriteLine("Fecha: " + DateTime.Now);
                sw.WriteLine("--------------------------------------------");

                var agrupados = ingresos
                    .GroupBy(i => i.Proveedor.Nombre)
                    .OrderBy(g => g.Key);

                foreach (var grupo in agrupados)
                {
                    sw.WriteLine($"Proveedor: {grupo.Key}");
                    foreach (var mov in grupo)
                    {
                        sw.WriteLine($"  - {mov.Fecha:dd/MM/yyyy} | {mov.Producto.Nombre} | Cantidad: {mov.Cantidad} | Obs: {mov.Observacion}");
                    }
                    sw.WriteLine();
                }
            }
        }

        public void ImprimirProductosBajoStock(List<Producto> productos, int umbral)
        {
            string path = Path.Combine(carpeta, "ProductosBajoStock.txt");
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("REPORTE: Productos con Bajo Stock");
                sw.WriteLine("Fecha: " + DateTime.Now);
                sw.WriteLine("--------------------------------------------");

                var bajos = productos.Where(p => p.Stock < umbral).ToList();

                if (bajos.Count == 0)
                {
                    sw.WriteLine("No hay productos por debajo del umbral.");
                }
                else
                {
                    foreach (var p in bajos)
                    {
                        sw.WriteLine($"Código: {p.Codigo} | Nombre: {p.Nombre} | Stock: {p.Stock}");
                    }
                }
            }
        }

        public void ImprimirHistorialMovimientosProducto(string nombreProducto, List<MovimientoStock> movimientos)
        {
            string safeName = string.Join("_", nombreProducto.Split(Path.GetInvalidFileNameChars()));
            string path = Path.Combine(carpeta, $"Historial_{safeName}.txt");

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine($"REPORTE: Historial de Movimientos - {nombreProducto}");
                sw.WriteLine("Fecha: " + DateTime.Now);
                sw.WriteLine("--------------------------------------------");

                foreach (var m in movimientos)
                {
                    string proveedor = (m is IngresoStock ingreso) ? ingreso.Proveedor.Nombre : "-";
                    string vencimiento = (m is IngresoStock ing && ing.FechaVencimiento != DateTime.MinValue)
                        ? ing.FechaVencimiento.ToShortDateString()
                        : "-";

                    sw.WriteLine($"{m.Fecha:dd/MM/yyyy} | {m.Tipo} | Cantidad: {m.Cantidad} | Obs: {m.Observacion} | Prov: {proveedor} | Vto: {vencimiento}");
                }
            }
        }
    }
}
