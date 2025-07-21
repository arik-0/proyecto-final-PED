public class Rubro
{
    private string nombre;
    private string descripcion;

    public string Nombre
    {
        get => nombre;
        set => nombre = value ?? throw new ArgumentNullException(nameof(Rubro));
    }

    public string Descripcion
    {
        get => descripcion;
        set => descripcion = value ?? "";
    }

    public Rubro(string nombre, string descripcion)
    {
        Nombre = nombre;
        Descripcion = descripcion;
    }
    public override string ToString() => Nombre;

}
