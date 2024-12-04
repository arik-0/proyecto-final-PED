using System;
using System.Collections.Generic;

namespace proyecto_final_PED
{
    public class Examen
    {
        public Guid ExamenId { get; set; }
        public DateTime Fecha { get; set; }
        public string Asignatura { get; set; }
        public List<Guid> IdPreguntas { get; set; }

        public Examen(string asignatura, DateTime fecha)
        {
            ExamenId = Guid.NewGuid();
            Fecha = fecha;
            Asignatura = asignatura;
            IdPreguntas = new List<Guid>();
        }

        public Examen(string linea)
        {
            // Constructor que inicializa desde una línea del archivo
            var datos = linea.Split(',');

            ExamenId = Guid.Parse(datos[0]); // ID del examen
            Fecha = DateTime.Parse(datos[1]); // Fecha
            Asignatura = datos[2]; // Asignatura

            // Lista de preguntas (convertir a GUID)
            IdPreguntas = new List<Guid>();
            for (int i = 3; i < datos.Length; i++)
            {
                if (Guid.TryParse(datos[i], out Guid idPregunta))
                {
                    IdPreguntas.Add(idPregunta);
                }
            }
        }

        // Genera el registro para guardar en el archivo Examenes.txt
        public string GenerarRegistro()
        {
            string preguntas = string.Join(",", IdPreguntas);
            return $"{ExamenId},{Fecha},{Asignatura},{preguntas}";
        }
    }
}
