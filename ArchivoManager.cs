using proyecto_final_PED;
using proyecto_final_PED.proyecto_final_PED;

public static class ArchivoManager
{
    private static string pathRubros = "Rubros.txt";
    private static string pathProductos = "Productos.txt";
    private static string pathProveedores = "Proveedores.txt";
    private static string pathMovimientos = "Movimientos.txt";

    public static void GuardarProveedores(List<Proveedor> proveedores)
    {
        var lineas = proveedores.Select(p =>
            $"{p.Id}|{p.Nombre}|{p.Contacto}|{p.Telefono}|{p.Direccion}");
        File.WriteAllLines(pathProveedores, lineas);
    }

    public static List<Proveedor> CargarProveedores()
    {
        if (!File.Exists(pathProveedores)) return new List<Proveedor>();

        return File.ReadAllLines(pathProveedores)
            .Where(l => !string.IsNullOrWhiteSpace(l))
            .Select(linea =>
            {
                var partes = linea.Split('|');

                var proveedor = new Proveedor(); // usa el constructor vacío internal

                proveedor.Nombre = partes[1];
                proveedor.Contacto = partes[2];
                proveedor.Telefono = partes[3];
                proveedor.Direccion = partes[4];
                proveedor.GetType()
                         .GetProperty("Id", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public)
                         ?.SetValue(proveedor, Guid.Parse(partes[0]));

                return proveedor;
            }).ToList();
    }

    //Para rubros
    public static void GuardarRubros(List<Rubro> rubros)
    {
        var lineas = rubros.Select(r => $"{r.Nombre}|{r.Descripcion}");
        File.WriteAllLines(pathRubros, lineas);
    }
    private static string pathCodigo = "ultimo_codigo.txt";

    public static int ObtenerNuevoCodigo()
    {
        int ultimoCodigo = 0;

        if (File.Exists(pathCodigo))
        {
            var contenido = File.ReadAllText(pathCodigo);
            int.TryParse(contenido, out ultimoCodigo);
        }

        int nuevoCodigo = ultimoCodigo + 1;
        File.WriteAllText(pathCodigo, nuevoCodigo.ToString());
        return nuevoCodigo;
    }


    public static List<Rubro> CargarRubros()
    {
        if (!File.Exists(pathRubros)) return new List<Rubro>();

        return File.ReadAllLines(pathRubros)
            .Where(l => !string.IsNullOrWhiteSpace(l))
            .Select(linea =>
            {
                var partes = linea.Split('|');
                return new Rubro(partes[0], partes[1]);
            })
            .ToList();
    }
    //Para Productos
    public static void GuardarProductos(List<Producto> productos)
    {
        var lineas = productos.Select(p =>
            $"{p.Codigo}|{p.Nombre}|{p.Descripcion}|{p.PrecioCompra}|{p.Stock}|{p.Rubro.Nombre}|{p.Rubro.Descripcion}");
        File.WriteAllLines(pathProductos, lineas);
    }

    public static List<Producto> CargarProductos(List<Rubro> rubros)
    {
        if (!File.Exists(pathProductos)) return new List<Producto>();

        return File.ReadAllLines(pathProductos)
            .Where(l => !string.IsNullOrWhiteSpace(l))
            .Select(linea =>
            {
                var partes = linea.Split('|');
                int codigo = int.Parse(partes[0]);
                string nombre = partes[1];
                string descripcion = partes[2];
                float precioCompra = float.Parse(partes[3]);
                int stock = int.Parse(partes[4]);
                string nombreRubro = partes[5];
                string descRubro = partes[6];

                // Buscar el rubro existente
                var rubro = rubros.FirstOrDefault(r => r.Nombre == nombreRubro);
                if (rubro == null)
                    rubro = new Rubro(nombreRubro, descRubro);

                return new Producto(codigo, nombre, descripcion, precioCompra, stock, rubro);
            }).ToList();

    }
    //Para Movimientos
    public static void GuardarMovimientos(List<MovimientoStock> movimientos)
    {
        var lineas = movimientos.Select(m =>
        {
            string tipo = m.Tipo;
            string proveedorId = "";
            string observaciones = "";

            if (m is IngresoStock ingreso)
            {
                proveedorId = ingreso.Proveedor.Id.ToString();
            }
            if(m is EgresoStock egreso)
            {
                observaciones = egreso.Observaciones;
            }

            return $"{tipo}|{m.Lote}|{m.Fecha:yyyy-MM-dd}|{m.Producto.Codigo}|{m.Cantidad}|{m.Observacion}|{proveedorId}|{observaciones}";
        });

        File.WriteAllLines("Movimientos.txt", lineas);
    }
    public static List<MovimientoStock> CargarMovimientos(List<Producto> productos, List<Proveedor> proveedores)
    {
        var movimientos = new List<MovimientoStock>();
        if (!File.Exists(pathMovimientos)) return movimientos;

        foreach (var linea in File.ReadAllLines(pathMovimientos))
        {
            if (string.IsNullOrWhiteSpace(linea)) continue;

            var partes = linea.Split('|');
            string tipo = partes[0];
            Guid lote = Guid.Parse(partes[1]);
            DateTime fecha = DateTime.Parse(partes[2]);
            int codProducto = int.Parse(partes[3]);
            int cantidad = int.Parse(partes[4]);
            string obs = partes[5];
            string proveedorIdStr = partes[6];

            var producto = productos.FirstOrDefault(p => p.Codigo == codProducto);
            if (producto == null) continue;

            MovimientoStock mov;

            if (tipo == "Ingreso")
            {
                var proveedor = proveedores.FirstOrDefault(p => p.Id.ToString() == proveedorIdStr);
                var ingreso = new IngresoStock
                {
                    Lote = lote,
                    FechaVencimiento = fecha,
                    Producto = producto,
                    Cantidad = cantidad,
                    Observacion = obs,
                    Proveedor = proveedor
                };
                mov = ingreso;
            }
            else if (tipo == "Egreso")
            {
                var egreso = new EgresoStock
                {
                    Lote = lote,
                    Fecha = fecha,
                    Producto = producto,
                    Cantidad = cantidad,
                    Observacion = obs
                };
                mov = egreso;
            }
            else continue;

            movimientos.Add(mov);
        }

        return movimientos;
    }

}
