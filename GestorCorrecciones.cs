using System;
using System.Collections.Generic;
using System.Linq;

namespace proyecto_final_PED
{
    public class GestorCorrecciones
    {
        public List<Pregunta> Preguntas { get; set; } // Lista de preguntas del examen
        private int puntuacion;               // Puntuación total del alumno
        private int indicePreguntaActual;     // Índice de la pregunta actual
        private Correccion correccion;        // Objeto de corrección para almacenar los resultados

        public GestorCorrecciones(List<Pregunta> preguntas, string alumno, Guid examenId)
        {
            this.Preguntas = preguntas;  // Inicializamos la lista de preguntas
            this.puntuacion = 0;
            this.indicePreguntaActual = 0;
            this.correccion = new Correccion(examenId, alumno);  // Inicializamos la corrección con las preguntas
        }

        // Muestra la pregunta actual
        public (string tituloPregunta, Guid idPregunta) MostrarPreguntaActual()
        { 
            // Obtenemos la pregunta actual
            Pregunta preguntaActual = Preguntas[indicePreguntaActual];
            return (preguntaActual.TxtPregunta, preguntaActual.PreguntaId);
        }

        // Verifica si la respuesta del alumno es correcta
        public bool VerificarRespuesta(Guid preguntaId, int respuestaAlumno)
        {
            // Buscar la pregunta actual por ID
            Pregunta preguntaActual = Preguntas.FirstOrDefault(p => p.PreguntaId == preguntaId);
            if (preguntaActual == null)
                return false;

            // Compara la respuesta del alumno con la respuesta correcta
            bool esCorrecta = preguntaActual.RespuestaCorrecta == respuestaAlumno;
            if (esCorrecta)
            {
                puntuacion++; // Incrementamos la puntuación si la respuesta es correcta
            }

            // Guardamos el resultado de la pregunta en la corrección
            correccion.Resultados.Add(new ResultadoPregunta
            {
                IdPregunta = preguntaId,
                Resultado = esCorrecta
            });

            return esCorrecta;
        }

        // Avanza a la siguiente pregunta
        public void AvanzarPregunta()
        {
            // Incrementa el índice para la siguiente pregunta, pero no lo excede
            if (indicePreguntaActual < Preguntas.Count - 1)
            {
                indicePreguntaActual++;
            }
            else
            {
                indicePreguntaActual = Preguntas.Count; // Fijar el índice al límite
            }
        }

        public bool HayMasPreguntas()
        {
            return indicePreguntaActual < Preguntas.Count;
        }

        // Devuelve la puntuación final
        public float CalcularPuntuacion()
        {
            float p = (float)puntuacion;
            float t = (float)indicePreguntaActual;
            return (p/t)*10;
        }

        // Guardar la corrección en un archivo de texto
        public void GuardarCorreccion()
        {
            string registro = correccion.GenerarRegistro();
            string filePath = "Correcciones.txt";  // Ruta del archivo de correcciones

            // Guardamos la corrección en el archivo
            System.IO.File.AppendAllText(filePath, registro + Environment.NewLine);
        }
    }
}
