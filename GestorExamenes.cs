using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_PED
{
    public class GestorExamenes
    {
        private string archivoExamenes = "Examenes.txt";
        private List<Pregunta> Preguntas;
        private List<Examen> Examenes;

        public GestorExamenes(List<Pregunta> preguntas)
        {
            Preguntas = preguntas;
            Examenes = LeerExamen();
        }

        
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
                    examen.IdPreguntas.Add(pregunta.PreguntaId);//string preguntas = string.Join(",", IdPreguntas);
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

        public List<Examen> LeerExamen()
        {
            List<Examen> lista = new List<Examen>();

            if (File.Exists(archivoExamenes))
            {
                using (StreamReader reader = new StreamReader(archivoExamenes))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        try
                        {
                            // Cada línea se convierte en un objeto Examen
                            Examen examen = new Examen(linea);
                            lista.Add(examen);
                        }
                        catch (Exception ex)
                        {
                            // Manejar errores específicos de formato o contenido
                            Console.WriteLine($"Error al procesar la línea: {linea}. Detalle: {ex.Message}");
                        }
                    }
                }
            }

            return lista;
        }

    }
}
