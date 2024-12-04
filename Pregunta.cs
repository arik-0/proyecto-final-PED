using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ProyectoFinal
{
    public class Pregunta
    {
        public int PreguntaId { get; set; }
        public string Texto { get; set; }
        public string Respuesta1 { get; set; }
        public string Respuesta2 { get; set; }
        public string Respuesta3 { get; set; }
        public string Respuesta4 { get; set; }
        public int RespuestaCorrecta { get; set; } // Índice de la respuesta correcta
        public string Asignatura { get; set; }
        public int Unidad { get; set; }
        public int Subunidad { get; set; }

        public Pregunta() { }

        // Constructor que recibe una línea del archivo CSV
        public Pregunta(string linea)
        {
            var datos = linea.Split(',');
            PreguntaId = int.Parse(datos[0]);
            Texto = datos[1];
            Respuesta1 = datos[2];
            Respuesta2 = datos[3];
            Respuesta3 = datos[4];
            Respuesta4 = datos[5];
            RespuestaCorrecta = int.Parse(datos[6]);
            Asignatura = datos[7];
            Unidad = int.Parse(datos[8]);
            Subunidad = int.Parse(datos[9]);
        }

        // Genera un registro en formato CSV para guardar en el archivo
        public string GenerarRegistro()
        {
            return $"{PreguntaId},{Texto},{Respuesta1},{Respuesta2},{Respuesta3},{Respuesta4},{RespuestaCorrecta},{Asignatura},{Unidad},{Subunidad}";
        }
    }
}
