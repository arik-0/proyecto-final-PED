using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_PED
{
    public partial class Form2 : Form
    {
        //variables globales
        private List<Pregunta> Preguntas;

        public Form2()
        {
            Preguntas = new List<Pregunta>();
            InitializeComponent();
        }

        private void volverAlMenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void crearpreguntabtn_Click(object sender, EventArgs e)
        {
            string textoPregunta = preguntatxt.Text.Trim();
            string respuesta1 = respuesta1txt.Text.Trim();
            string respuesta2 = respuesta2txt.Text.Trim();
            string respuesta3 = respuesta3txt.Text.Trim();
            string respuesta4 = respuesta4txt.Text.Trim();
            int respuestaCorrecta = (int)correctaupdown.Value - 1;
            // Crear una nueva pregunta
            Pregunta nuevaPregunta = new Pregunta
            {
                PreguntaId = Preguntas.Count + 1, // Asignar ID único
                TxtPregunta = textoPregunta,
                Respuesta1 = respuesta1,
                Respuesta2 = respuesta2,
                Respuesta3 = respuesta3,
                Respuesta4 = respuesta4,
                RespuestaCorrecta = respuestaCorrecta,
                Asignatura = "Por definir", // Opcional: agregar campo para asignatura en el formulario
                Unidad = 0,                // Opcional: agregar unidad y subunidad en el formulario
                Subunidad = 0
            };

            GestorPreguntas.AgregarPregunta(Pregunta nuevaPregunta);
        }
    }
}
