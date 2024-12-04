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
        private string linea;

        public Guid PreguntaId { get; set; }
        public string TxtPregunta { get; set; }
        public string Respuesta1 { get; set; }
        public string Respuesta2 { get; set; }
        public string Respuesta3 { get; set; }
        public string Respuesta4 { get; set; }
        public int RespuestaCorrecta { get; set; } // Índice de la respuesta correcta
        public string Asignatura { get; set; }
        public int Unidad { get; set; }
        public int Subunidad { get; set; }

        //
        public Pregunta(Guid idPregunta, string textoPregunta, string respuesta1, string respuesta2, string respuesta3, string respuesta4, int respuestaCorrecta, string asignatura, int unidad, int subunidad)
        {
            PreguntaId = idPregunta;
            TxtPregunta = textoPregunta;
            Respuesta1 = respuesta1;
            Respuesta2 = respuesta2;
            Respuesta3 = respuesta3;
            Respuesta4 = respuesta4;
            RespuestaCorrecta = respuestaCorrecta;
            Asignatura = asignatura;
            Unidad = unidad;
            Subunidad = subunidad;
        }

        public Pregunta(string linea)
        {
            var datos = linea.Split(',');
            PreguntaId = Guid.Parse(datos[0]);
            TxtPregunta = datos[1];
            Respuesta1 = datos[2];
            Respuesta2 = datos[3];
            Respuesta3 = datos[4];
            Respuesta4 = datos[5];
            RespuestaCorrecta = int.Parse(datos[6]);
            Asignatura = datos[7];
            Unidad = int.Parse(datos[8]);
            Subunidad = int.Parse(datos[9]);
        }

        // Constructor para inicializar desde una línea de texto

        // Genera una línea para guardar en el archivo
        public string GenerarRegistro()
        {
            return $"{PreguntaId},{TxtPregunta},{Respuesta1},{Respuesta2},{Respuesta3},{Respuesta4},{RespuestaCorrecta},{Asignatura},{Unidad},{Subunidad}";
        }
    }
}