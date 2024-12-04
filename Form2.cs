using ProyectoFinal;
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
        public List<Pregunta> Preguntas;
        GestorPreguntas gestor = new GestorPreguntas();

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
            int respuestaCorrecta = Convert.ToInt32(correctaupdown.Value - 1);
            string asignatura = string.Join(", ", asignaturaselect.CheckedItems.Cast<string>());
            int unidad = (int)unidadupdown.Value;
            int subunidad = (int)subunidadupdown.Value;
            // Crear una nueva pregunta
            Pregunta nuevaPregunta = new Pregunta
            {
                PreguntaId = Preguntas.Count + 1, // Asignar ID único
                TxtPregunta = textoPregunta,
                Respuesta1 = respuesta1,
                Respuesta2 = respuesta2,
                Respuesta3 = respuesta3,
                Respuesta4 = respuesta4,
                Asignatura = asignatura, // Opcional: agregar campo para asignatura en el formulario
                Unidad = unidad,                // Opcional: agregar unidad y subunidad en el formulario
                Subunidad = subunidad,
                RespuestaCorrecta = respuestaCorrecta
            };

            gestor.AgregarPregunta(nuevaPregunta);

        }
        private void asignaturaselect_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Desmarcar todos los demás elementos excepto el que se está marcando
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < asignaturaselect.Items.Count; i++)
                {
                    if (i != e.Index) // No modificar el elemento actual
                    {
                        asignaturaselect.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void asignaturaselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}