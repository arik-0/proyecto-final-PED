using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_PED
{
    public class Examen
    {
        public int ExamenId { get; set; }
        public DateTime Fecha { get; set; }
        public string Asignatura { get; set; }
        public List<int> ListaPreguntas { get; set; }

        public Examen(int examenId, DateTime fecha, string asignatura, List<int> listaPreguntas)
        {
            ExamenId = examenId;
            Fecha = fecha;
            Asignatura = asignatura;
            ListaPreguntas = listaPreguntas;
        }

        public override string ToString()
        {
            return $"Examen ID: {ExamenId}\nFecha: {Fecha}\nAsignatura: {Asignatura}\nPreguntas: {string.Join(", ", ListaPreguntas)}";
        }
    }
}
