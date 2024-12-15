using System;
using System.Collections.Generic;
using System.Linq;

namespace proyecto_final_PED
{
    public class GestorCorrecciones
    {
        public List<Pregunta> Preguntas { get; set; }
        private int puntuacion;            
        private int indicePreguntaActual;     
        private Correccion correccion;       

        public GestorCorrecciones(List<Pregunta> preguntas, string alumno, Guid examenId)
        {
            this.Preguntas = preguntas; 
            this.puntuacion = 0;
            this.indicePreguntaActual = 0;
            this.correccion = new Correccion(examenId, alumno);  
        }

        public (string tituloPregunta, Guid idPregunta) MostrarPreguntaActual()
        { 
            Pregunta preguntaActual = Preguntas[indicePreguntaActual];
            return (preguntaActual.TxtPregunta, preguntaActual.PreguntaId);
        }
        
        public bool VerificarRespuesta(Guid preguntaId, int respuestaAlumno)
        {
            Pregunta preguntaActual = Preguntas.FirstOrDefault(p => p.PreguntaId == preguntaId);
            if (preguntaActual == null)
                return false;
           
            bool esCorrecta = preguntaActual.RespuestaCorrecta == respuestaAlumno;
            if (esCorrecta)
            {
                puntuacion++; 
            }
            
            correccion.Resultados.Add(new ResultadoPregunta
            {
                IdPregunta = preguntaId,
                Resultado = esCorrecta
            });

            return esCorrecta;
        }

        public void AvanzarPregunta()
        {
            
            if (indicePreguntaActual < Preguntas.Count - 1)
            {
                indicePreguntaActual++;
            }
            else
            {
                indicePreguntaActual = Preguntas.Count; 
            }
        }

        public bool HayMasPreguntas()
        {
            return indicePreguntaActual < Preguntas.Count;
        }
        
        public float CalcularPuntuacion()
        {
            float p = (float)puntuacion;
            float t = (float)indicePreguntaActual;
            return (p/t)*10;
        }
        
        public void GuardarCorreccion()
        {
            string registro = correccion.GenerarRegistro();
            string filePath = "Correcciones.txt";  

            
            System.IO.File.AppendAllText(filePath, registro + Environment.NewLine);
        }
    }
}
