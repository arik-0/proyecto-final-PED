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

        public GestorPreguntas()
        {
            Preguntas = new List<Pregunta>();
            CargarPreguntas();
        }

        public void AgregarPregunta(Pregunta pregunta)
        {
            Preguntas.Add(pregunta);
            GuardarPreguntas();
        }

        public void EliminarPregunta(int preguntaId)
        {
            Preguntas.RemoveAll(p => p.PreguntaId == preguntaId);
            GuardarPreguntas();
        }

        public void GuardarPreguntas()
        {
            using (StreamWriter sw = new StreamWriter(archivoPreguntas))
            {
                foreach (var pregunta in Preguntas)
                {
                    // Formato: PreguntaId, TextoPregunta, Respuesta1, Respuesta2, Respuesta3, Respuesta4, RespuestaCorrecta, Asignatura, Unidad, Subunidad
                    string linea = $"{pregunta.PreguntaId},{pregunta.TxtPregunta},{pregunta.Respuesta1},{pregunta.Respuesta2},{pregunta.Respuesta3},{pregunta.Respuesta4},{pregunta.RespuestaCorrecta},{pregunta.Asignatura},{pregunta.Unidad},{pregunta.Subunidad}";
                    sw.WriteLine(linea);
                }
            }
        }


        public void CargarPreguntas()
        {
            // Verifica si el archivo existe antes de intentar leerlo
            if (!File.Exists(archivoPreguntas)) return;

            using (StreamReader sr = new StreamReader(archivoPreguntas))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    // Divide la línea en campos separados por comas
                    var datos = linea.Split(',');

                    // Crea una nueva instancia de Pregunta con los campos individuales
                    Preguntas.Add(new Pregunta
                    {
                        PreguntaId = int.Parse(datos[0]),
                        TxtPregunta = datos[1],
                        Respuesta1 = datos[2],
                        Respuesta2 = datos[3],
                        Respuesta3 = datos[4],
                        Respuesta4 = datos[5],
                        RespuestaCorrecta = int.Parse(datos[6]),
                        Asignatura = datos[7],
                        Unidad = int.Parse(datos[8]),
                        Subunidad = int.Parse(datos[9])
                    });
                }
            }
        }

    }
}
