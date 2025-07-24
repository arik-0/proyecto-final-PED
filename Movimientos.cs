using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_PED
{
    public abstract class MovimientoStock
    {
        // Atributos privados
        private Guid lote;
        private DateTime fecha;
        private Producto producto;
        private int cantidad;
        private string observacion;

        // Propiedades públicas
        public Guid Lote
        {
            get => lote;
            set => lote = value;
        }

        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }


        public Producto Producto
        {
            get => producto;
            set => producto = value ?? throw new ArgumentNullException(nameof(Producto));
        }

        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }

        public string Observacion
        {
            get => observacion;
            set => observacion = value ?? "";
        }

        // Propiedad abstracta para saber si es ingreso o egreso
        public abstract string Tipo { get; }

        public override string ToString()
        {
            return $"{Fecha:dd/MM/yyyy} | {Tipo} de {Cantidad} u. - {Producto.Nombre}";
        }
    }
}
