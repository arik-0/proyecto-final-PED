using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace proyecto_final_PED
{
    public class Impresion
    {
        private string archivoExamenes = "Examenes.txt";
        private string archivoPreguntas = "Preguntas.txt";
        private string directorioImpresiones = "Impresiones";

        public Impresion()
        {

        }

        public void GenerarImpresion(Guid examenId, string universidad, string carrera)
        {
            try
            {
                // Leer el examen desde Examenes.txt
                Examen examen = LeerExamenPorId(examenId);

                if (examen == null)
                {
                    Console.WriteLine($"No se encontró el examen con ID {examenId}.");
                    return;
                }

                // Leer todas las preguntas desde Preguntas.txt
                List<Pregunta> preguntas = LeerPreguntas();

                // Filtrar las preguntas correspondientes al examen
                var preguntasDelExamen = preguntas.Where(p => examen.IdPreguntas.Contains(p.PreguntaId)).ToList();

                // Obtener un nombre único para el archivo de impresión
                string archivoImpresion = ObtenerNombreArchivoUnico();

                // Generar la impresión
                using (StreamWriter writer = new StreamWriter(archivoImpresion, false)) // Sobrescribir el archivo
                {
                    // Escribir la cabecera del examen
                    writer.WriteLine("=================================================");
                    writer.WriteLine($"Universidad: {universidad}");
                    writer.WriteLine($"Carrera: {carrera}");
                    writer.WriteLine($"Asignatura: {examen.Asignatura}");
                    writer.WriteLine($"Fecha: {examen.Fecha}");
                    writer.WriteLine($"ID Examen: {examen.ExamenId}");
                    writer.WriteLine("=================================================\n");

                    // Escribir las preguntas
                    int contador = 1;
                    foreach (var pregunta in preguntasDelExamen)
                    {
                        writer.WriteLine($"Pregunta {contador}: {pregunta.TxtPregunta}");
                        writer.WriteLine($"  a) {pregunta.Respuesta1}");
                        writer.WriteLine($"  b) {pregunta.Respuesta2}");

                        // Imprimir respuestas opcionales si existen
                        if (!string.IsNullOrWhiteSpace(pregunta.Respuesta3))
                            writer.WriteLine($"  c) {pregunta.Respuesta3}");
                        if (!string.IsNullOrWhiteSpace(pregunta.Respuesta4))
                            writer.WriteLine($"  d) {pregunta.Respuesta4}");

                        writer.WriteLine(); // Espacio entre preguntas
                        contador++;
                    }

                    writer.WriteLine("=================================================");
                    writer.WriteLine("Fin del examen.");
                }

                Console.WriteLine($"El archivo de impresión del examen se generó correctamente: {archivoImpresion}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al generar el archivo de impresión: {ex.Message}");
            }
        }


        private string ObtenerNombreArchivoUnico()
        {
            int contador = 1;
            string archivoImpresion;

            do
            {
                archivoImpresion = Path.Combine(directorioImpresiones, $"ImpresionExamen_{contador}.txt");
                contador++;
            } while (File.Exists(archivoImpresion)); // Incrementa hasta encontrar un nombre único

            return archivoImpresion;
        }

        private Examen LeerExamenPorId(Guid examenId)
        {
            if (File.Exists(archivoExamenes))
            {
                using (StreamReader reader = new StreamReader(archivoExamenes))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        Examen examen = new Examen(linea);
                        if (examen.ExamenId == examenId)
                        {
                            return examen;
                        }
                    }
                }
            }

            return null;
        }

        private List<Pregunta> LeerPreguntas()
        {
            List<Pregunta> lista = new List<Pregunta>();

            if (File.Exists(archivoPreguntas))
            {
                using (StreamReader reader = new StreamReader(archivoPreguntas))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        try
                        {
                            lista.Add(new Pregunta(linea));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error al procesar la línea: {linea}. Detalle: {ex.Message}");
                        }
                    }
                }
            }

            return lista;
        }
    }
}
