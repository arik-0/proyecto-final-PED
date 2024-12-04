using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace proyecto_final_PED
{
    public class GestorExamenes
    {
        private string archivoExamenes = "Examenes.txt";
        private List<Pregunta> Preguntas;

        public GestorExamenes(List<Pregunta> preguntas)
        {
            Preguntas = preguntas;
        }

        /// <returns>Un objeto Examen con las preguntas seleccionadas.</returns>
        public Examen GenerarExamen(string asignatura, List<int> unidadesSeleccionadas, DateTime fechaExamen)
        {
            Examen examen = new Examen(asignatura, fechaExamen);

            // Filtrar las preguntas de las unidades seleccionadas
            foreach (var unidad in unidadesSeleccionadas)
            {
                // Filtrar las preguntas por unidad
                var preguntasPorUnidad = Preguntas.Where(p => p.Asignatura == asignatura && p.Unidad == unidad).ToList();

                // Tomar una pregunta por cada subunidad dentro de la unidad
                var preguntasPorSubunidad = preguntasPorUnidad.GroupBy(p => p.Subunidad)
                                                              .Select(g => g.OrderBy(x => Guid.NewGuid()).First()) // Aleatorio por subunidad
                                                              .ToList();

                // Agregar las preguntas seleccionadas al examen
                foreach (var pregunta in preguntasPorSubunidad)
                {
                    examen.IdPreguntas.Add(pregunta.PreguntaId);
                }
            }

            // Guardar el examen en el archivo
            GuardarExamen(examen);

            return examen;
        }

        private void GuardarExamen(Examen examen)
        {
            try
            {
                // Guardar el examen en el archivo
                using (StreamWriter writer = new StreamWriter(archivoExamenes, true))
                {
                    writer.WriteLine(examen.GenerarRegistro());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el examen: {ex.Message}");
            }
        }
    }
}
