using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_PED
{
    public class Pregunta
    {
        /*PreguntaId, txtPregunta, Lista de respuestas, respuestaCorrecta, asignatura, unidad, subunidad.*/
        public int PreguntaId{ get; set; }
        public string TxtPregunta { get; set; }
        public List<string> Opciones { get; set; }
        public int RespuestaCorrecta { get; set; }
        public string Asignatura { get; set; }
        public int Unidad { get; set; }
        public int SubUnidad { get; set; }

        public Pregunta(int preguntaId, string textoPregunta, List<string> opciones, int respuestaCorrecta, string asignatura, int unidad, int subunidad)
        {
            if (opciones.Count > 4)
                throw new ArgumentException("La pregunta no puede tener más de 4 opciones.");

            PreguntaId = preguntaId;
            TxtPregunta = textoPregunta;
            Opciones = opciones;
            RespuestaCorrecta = respuestaCorrecta;
            Asignatura = asignatura;
            Unidad = unidad;
            SubUnidad = subunidad;
        }

        public bool EsRespuestaCorrecta(int indiceRespuesta)
        {
            return RespuestaCorrecta == indiceRespuesta;
        }

        public override string ToString()
        {
            string opcionesTexto = "";
            for (int i = 0; i < Opciones.Count; i++)
            {
                opcionesTexto += $"{i + 1}. {Opciones[i]}\n";
            }

            return $"ID: {PreguntaId}\nPregunta: {TxtPregunta}\nOpciones:\n{opcionesTexto}Asignatura: {Asignatura}\nUnidad: {Unidad}, Subunidad: {SubUnidad}";
        }
    }
}
