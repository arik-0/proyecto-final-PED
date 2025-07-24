using System;

namespace proyecto_final_PED
{
    public class Producto
    {
        // Atributos privados
        private int codigo;
        private string nombre;
        private string descripcion;
        private float precioCompra;
        private int stock;
        private Rubro rubro;

        // Constructor
        public Producto(int codigo, string nombre, string descripcion, float precioCompra, int stock, Rubro rubro)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCompra = precioCompra;
            Stock = stock;
            Rubro = rubro;
        }

        // Propiedades
        public int Codigo
        {
            get => codigo;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El código del producto debe ser un número positivo.");
                codigo = value;
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre del producto no puede estar vacío.");
                nombre = value;
            }
        }

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value ?? "";
        }

        public float PrecioCompra
        {
            get => precioCompra;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio de compra debe ser mayor a cero.");
                precioCompra = value;
            }
        }

        // Precio de venta calculado automáticamente (50% más)
        public float PrecioVenta => precioCompra * 1.5f;

        public int Stock
        {
            get => stock;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El stock no puede ser negativo.");
                stock = value;
            }
        }

        public Rubro Rubro
        {
            get => rubro;
            set => rubro = value ?? throw new ArgumentNullException(nameof(Rubro), "El rubro no puede ser nulo.");
        }

       

        public override string ToString()
        {
            return $"Cod: {Codigo} | {Nombre} | Stock: {Stock} | P. Venta: ${PrecioVenta:0.00} ";
        }
    }
}
