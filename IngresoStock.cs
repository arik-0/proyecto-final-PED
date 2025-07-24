using proyecto_final_PED.proyecto_final_PED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_PED
{
    public class IngresoStock : MovimientoStock
    {
        private Proveedor proveedor;
        private DateTime fechaVencimiento;

        public DateTime FechaVencimiento
        {
            get => fechaVencimiento;
            set => fechaVencimiento = value;
        }
        public Proveedor Proveedor
        {
            get => proveedor;
            set => proveedor = value ?? throw new ArgumentNullException(nameof(Proveedor));
        }

        public override string Tipo => "Ingreso";

        public override string ToString()
        {
            return $"{base.ToString()} | Proveedor: {Proveedor?.Nombre} | Vence: {FechaVencimiento:dd/MM/yyyy}";
        }

    }
}