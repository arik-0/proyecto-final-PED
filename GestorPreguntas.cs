using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_PED
{

    public class GestorPreguntas
    {
        private string archivoPreguntas = "Preguntas.txt";
        public List<Pregunta> Preguntas { get; private set; }
        private int ultimoId;

        public GestorPreguntas()
        {
            Preguntas = new List<Pregunta>();
            Preguntas = LeerPreguntas();
            // ultimoId = Preguntas.Count > 0 ? Preguntas.Max(p => p.PreguntaId) : 0; // Establecer el último ID usado
        }



        public void EliminarPregunta(Guid preguntaId)
        {
            Preguntas.RemoveAll(p => p.PreguntaId == preguntaId);
            GuardarTodasLasPreguntas();
        }

        public void GuardarPreguntas(Pregunta unaPregunta)
        {
            // Verificar si el archivo no existe y crearlo vacío
            if (!File.Exists(archivoPreguntas))
            {
                using (File.Create(archivoPreguntas)) { }
            }

            // Escribir en el archivo
            using (StreamWriter writer = new StreamWriter(archivoPreguntas, true))
            {
                writer.WriteLine(unaPregunta.GenerarRegistro());
            }
            Preguntas.Add(unaPregunta);
        }

        public void GuardarTodasLasPreguntas()
        {
            using (StreamWriter writer = new StreamWriter(archivoPreguntas, false)) // Sobrescribe el archivo
            {
                foreach (var pregunta in Preguntas)
                {
                    writer.WriteLine(pregunta.GenerarRegistro());
                }
            }
        }

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
                        try
                        {
                            lista.Add(new Pregunta(linea));
                        }
                        catch (Exception ex)
                        {
                            // Manejar el error, por ejemplo, registrarlo y continuar
                            Console.WriteLine($"Error al leer la línea: {linea}. Excepción: {ex.Message}");
                        }
                    }
                }
            }

            return lista;
        }


        public void ModificarPregunta(Guid preguntaId, Pregunta nuevaPregunta)
        {
            Pregunta preguntaAModificar = Preguntas.FirstOrDefault(p => p.PreguntaId == preguntaId);

            if (preguntaAModificar != null)
            {
                // Actualizar los datos de la pregunta
                preguntaAModificar.TxtPregunta = nuevaPregunta.TxtPregunta;
                preguntaAModificar.Respuesta1 = nuevaPregunta.Respuesta1;
                preguntaAModificar.Respuesta2 = nuevaPregunta.Respuesta2;
                preguntaAModificar.Respuesta3 = nuevaPregunta.Respuesta3;
                preguntaAModificar.Respuesta4 = nuevaPregunta.Respuesta4;
                preguntaAModificar.RespuestaCorrecta = nuevaPregunta.RespuestaCorrecta;
                preguntaAModificar.Asignatura = nuevaPregunta.Asignatura;
                preguntaAModificar.Unidad = nuevaPregunta.Unidad;
                preguntaAModificar.Subunidad = nuevaPregunta.Subunidad;

                // Guardar todos los cambios en el archivo
                GuardarTodasLasPreguntas();
            }
            else
            {
                Console.WriteLine("La pregunta no se encontró.");
            }
        }
        public Pregunta BuscarPreguntaPorId(Guid preguntaId)
        {
            // Buscar la pregunta por su ID
            return Preguntas.FirstOrDefault(p => p.PreguntaId == preguntaId);
        }

    }
}/*using (StreamWriter writer = new StreamWriter(archivoPreguntas, false)) // 'false' sobrescribe el archivo
             {
                 // El archivo se sobrescribe vacío
                 writer.Write(string.Empty);
             }*/