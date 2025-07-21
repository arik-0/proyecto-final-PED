using proyecto_final_PED;

public static class ArchivoManager
{
    private static string pathRubros = "Rubros.txt";
    private static string pathProductos = "Productos.txt";

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

    public static void GuardarProductos(List<Producto> productos)
    {
        var lineas = productos.Select(p =>
            $"{p.Codigo}|{p.Nombre}|{p.Descripcion}|{p.PrecioCompra}|{p.Stock}|{p.Rubro.Nombre}|{p.Rubro.Descripcion}|{p.FechaVencimiento:yyyy-MM-dd}");
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
                DateTime fechaVto = DateTime.Parse(partes[7]);

                // Buscar el rubro existente
                var rubro = rubros.FirstOrDefault(r => r.Nombre == nombreRubro);
                if (rubro == null)
                    rubro = new Rubro(nombreRubro, descRubro);

                return new Producto(codigo, nombre, descripcion, precioCompra, stock, rubro, fechaVto);
            }).ToList();

    }
}
