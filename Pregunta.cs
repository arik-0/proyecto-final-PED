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
        public int PreguntaId { get; set; }
        public string TxtPregunta { get; set; }
        public string Respuesta1 { get; set; }
        public string Respuesta2 { get; set; }
        public string Respuesta3 { get; set; }
        public string Respuesta4 { get; set; }
        public int RespuestaCorrecta { get; set; } // Índice basado en 0 (0 = Respuesta1, 1 = Respuesta2, etc.)
        public string Asignatura { get; set; }
        public int Unidad { get; set; }
        public int Subunidad { get; set; }

        // Método para verificar si una respuesta proporcionada es correcta
        public bool EsRespuestaCorrecta(int indiceRespuesta)
        {
            return RespuestaCorrecta == indiceRespuesta;
        }

        public override string ToString()
        {
            return $"ID: {PreguntaId}\nPregunta: {TxtPregunta}\n1) {Respuesta1}\n2) {Respuesta2}\n3) {Respuesta3}\n4) {Respuesta4}\nAsignatura: {Asignatura}, Unidad: {Unidad}, Subunidad: {Subunidad}";
        }
    }
}
