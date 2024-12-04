using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_PED
{
    public class Examen
    {
        public Guid ExamenId { get; set; }
        public DateTime Fecha { get; set; }
        public string Asignatura { get; set; }
        public List<Guid> IdPreguntas { get; set; }

        public Examen(string asignatura)
        {
            ExamenId = Guid.NewGuid();
            Fecha = DateTime.Now;
            Asignatura = asignatura;
            IdPreguntas = new List<Guid>();
        }

        // Genera el registro para guardar en el archivo Examenes.txt
        public string GenerarRegistro()
        {
            string preguntas = string.Join(",", IdPreguntas);
            return $"{ExamenId},{Fecha},{Asignatura},{preguntas}";
        }
    }
}
