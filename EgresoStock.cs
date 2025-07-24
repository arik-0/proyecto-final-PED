using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_PED
{
    public class EgresoStock : MovimientoStock
    {
        public override string Tipo => "Egreso";
        public string? Observaciones { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
