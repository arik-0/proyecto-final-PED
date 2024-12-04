using proyecto_final_PED;
using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal
{
    public class GestorPreguntas
    {
        string archivoPreguntas = "Preguntas.txt";

        // Leer preguntas desde el archivo
        public List<Pregunta> LeerPreguntas()
        {
            List<Pregunta> lista = new List<Pregunta>();

            if (File.Exists(archivoPreguntas))
            {
                using (StreamReader reader = new StreamReader(archivoPreguntas))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        lista.Add(new Pregunta(linea));
                    }
                }
            }

            return lista;
        }

        // Guardar una nueva pregunta en el archivo
        public void GuardarPregunta(Pregunta nuevaPregunta)
        {
            using (StreamWriter writer = new StreamWriter(archivoPreguntas, true))
            {
                writer.WriteLine(nuevaPregunta.GenerarRegistro());
            }
        }

        // Sobreescribe el archivo con una nueva lista de preguntas
        public void GuardarListaPreguntas(List<Pregunta> preguntas)
        {
            using (StreamWriter writer = new StreamWriter(archivoPreguntas, false))
            {
                foreach (var pregunta in preguntas)
                {
                    writer.WriteLine(pregunta.GenerarRegistro());
                }
            }
        }
    }
}
