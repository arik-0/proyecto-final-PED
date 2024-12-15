using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_PED
{
    public class Correccion
    {
        public Guid ExamenId { get; set; }
        public string Alumno { get; set; } 
        public List<ResultadoPregunta> Resultados { get; set; } 
        public int Puntuacion { get; set; } 
        public DateTime FechaCorreccion { get; set; }

        public Correccion(Guid examenId, string alumno)
        {
            ExamenId = examenId;
            Alumno = alumno;
            Resultados = new List<ResultadoPregunta>();
            FechaCorreccion = DateTime.Now;
        }

       public string GenerarRegistro()
       {
           // Formato: ExamenId, Alumno, FechaCorreccion, Puntuacion, [PreguntaId:Resultado]
            string resultados = string.Join(";", Resultados.Select(r => $"{r.IdPregunta}:{r.Resultado}"));
            return $"{ExamenId},{Alumno},{FechaCorreccion},{Puntuacion},{resultados}";
       }
    }
}
