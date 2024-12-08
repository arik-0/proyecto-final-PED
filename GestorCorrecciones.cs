using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace proyecto_final_PED
{
    public class GestorCorrecciones
    {
        private List<Pregunta> preguntas;
        private int puntuacion;

        public GestorCorrecciones(List<Pregunta> preguntas)
        {
            this.preguntas = preguntas;
            this.puntuacion = 0;
        }

        public (string tituloPregunta, Guid idPregunta) MostrarPreguntaActual(int indice)
        {
            // Validamos si el índice es válido
            if (indice < 0 || indice >= preguntas.Count)
            {
                return (string.Empty, Guid.Empty);
            }

            Pregunta preguntaActual = preguntas[indice];
            return (preguntaActual.TxtPregunta, preguntaActual.PreguntaId);
        }

        public bool VerificarRespuesta(Guid preguntaId, int respuestaAlumno)
        {
            Pregunta preguntaActual = preguntas.FirstOrDefault(p => p.PreguntaId == preguntaId);
            if (preguntaActual == null)
                return false;

            bool esCorrecta = preguntaActual.RespuestaCorrecta == respuestaAlumno;
            if (esCorrecta)
            {
                puntuacion++;
            }
            return esCorrecta;
        }

        public int CalcularPuntuacion()
        {
            return puntuacion;
        }

        public void GuardarCorreccion(string alumno, Guid examenId, int puntuacion)
        {
            string registro = $"ExamenId: {examenId}, Alumno: {alumno}, Puntuación: {puntuacion}";
            System.IO.File.AppendAllText("Correcciones.txt", registro + Environment.NewLine);
        }
    }
}
