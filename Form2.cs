
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
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void volverAlMenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void MostrarPreguntas()
        {
            Preguntas = gestor.LeerPreguntas();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Preguntas;
        }
        void MostrarPreguntasPorUnidad(int unidad)
        {
            Preguntas = gestor.LeerPreguntas();
            var preguntasFiltradas = Preguntas.Where(p => p.Unidad == unidad).ToList();

            // Actualizar el DataGridView
            dataGridView1.DataSource = null; // Restablece el origen de datos
            dataGridView1.DataSource = preguntasFiltradas;
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
            string asignatura = asignaturatxt.Text.Trim().ToUpper();
            int unidad = Convert.ToInt32(unidadupdown.Value);
            int subunidad = Convert.ToInt32(subunidadupdown.Value);
            // Crear una nueva pregunta
            Pregunta nuevaPregunta = new Pregunta(Guid.NewGuid(), textoPregunta, respuesta1, respuesta2, respuesta3, respuesta4, respuestaCorrecta, asignatura, unidad, subunidad);
            gestor.GuardarPreguntas(nuevaPregunta);
            gestor.LeerPreguntas();
            MostrarPreguntas();

        }
        private void modificarpregbtn_Click(object sender, EventArgs e) 
        {

        }
        private void borrarpreguntabtn_Click(object sender, EventArgs e) 
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                Pregunta preguntaSeleccionada = filaSeleccionada.DataBoundItem as Pregunta;

                if (preguntaSeleccionada != null)
                {
                    // Confirmar la eliminación con el usuario
                    DialogResult resultado = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar la pregunta con ID {preguntaSeleccionada.PreguntaId}?",
                        "Confirmación de eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar la pregunta utilizando el gestor
                        gestor.EliminarPregunta(preguntaSeleccionada.PreguntaId);

                        // Refrescar la lista y la grilla
                        Preguntas = gestor.LeerPreguntas();
                        MostrarPreguntas();

                        MessageBox.Show("Pregunta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la pregunta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void asignaturaselect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}