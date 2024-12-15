using proyecto_final_PED;
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
        //globales
        private List<Pregunta> Preguntas;
        GestorPreguntas gestor = new GestorPreguntas();

        public Form2()
        {
            InitializeComponent();
            Preguntas = new List<Pregunta>();
            Preguntas = gestor.LeerPreguntas();
            MostrarPreguntas();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            MostrarPreguntas();
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
            if (preguntasFiltradas.Count == 0) { MessageBox.Show("No hay preguntas de esa unidad"); }
            
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = preguntasFiltradas;
            }
        }

        private void crearpreguntabtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(preguntatxt.Text))
            {
                MessageBox.Show("El campo de la pregunta no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (string.IsNullOrWhiteSpace(respuesta1txt.Text) || string.IsNullOrWhiteSpace(respuesta2txt.Text))
            {
                MessageBox.Show("Las respuestas 1 y 2 deben estar completas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (respuesta1txt.Text == respuesta2txt.Text)
            {
                MessageBox.Show("Las respuestas 1 y 2 no deben ser iguales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (correctaupdown.Value < 1 || correctaupdown.Value > 4)
            {
                MessageBox.Show("Debe seleccionar una respuesta correcta válida (entre 1 y 4).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(asignaturatxt.Text))
            {
                MessageBox.Show("Debe seleccionar una asignatura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string textoPregunta = preguntatxt.Text.Trim();
            string respuesta1 = respuesta1txt.Text.Trim();
            string respuesta2 = respuesta2txt.Text.Trim();
            string respuesta3 = respuesta3txt.Text.Trim();
            string respuesta4 = respuesta4txt.Text.Trim();
            int respuestaCorrecta = (int)correctaupdown.Value - 1;
            string asignatura = asignaturatxt.Text.Trim().ToUpper();
            int unidad = Convert.ToInt32(unidadupdown.Value);
            int subunidad = Convert.ToInt32(subunidadupdown.Value);
            
            Pregunta nuevaPregunta = new Pregunta(Guid.NewGuid(), textoPregunta, respuesta1, respuesta2, respuesta3, respuesta4, respuestaCorrecta, asignatura, unidad, subunidad);
            gestor.GuardarPreguntas(nuevaPregunta);
            gestor.LeerPreguntas();
            MostrarPreguntas();
            preguntatxt.Clear(); respuesta1txt.Clear(); respuesta2txt.Clear(); respuesta3txt.Clear();respuesta4txt.Clear(); asignaturatxt.Clear();

        }

        private void borrarPregbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                Pregunta preguntaSeleccionada = filaSeleccionada.DataBoundItem as Pregunta;

                if (preguntaSeleccionada != null)
                {
                    
                    DialogResult resultado = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar la pregunta con ID {preguntaSeleccionada.PreguntaId}?",
                        "Confirmación de eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resultado == DialogResult.Yes)
                    {  
                        gestor.EliminarPregunta(preguntaSeleccionada.PreguntaId);
 
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

        private void ordenarporunidadbtn_Click(object sender, EventArgs e)
        {
            int unidad = (int)unidadupdown.Value;
            MostrarPreguntasPorUnidad(unidad);
        }

        private void modificarPregbtn_Click_1(object sender, EventArgs e)
        {      
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                Pregunta preguntaSeleccionada = filaSeleccionada.DataBoundItem as Pregunta;

                if (preguntaSeleccionada != null)
                {
                    DialogResult resultado = MessageBox.Show(
                        $"¿Deseas modificar la pregunta con ID {preguntaSeleccionada.PreguntaId}?",
                        "Confirmación de modificación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        
                        Pregunta nuevaPregunta = new Pregunta(
                            preguntaSeleccionada.PreguntaId,
                            preguntatxt.Text.Trim(),
                            respuesta1txt.Text.Trim(),
                            respuesta2txt.Text.Trim(),
                            respuesta3txt.Text.Trim(),
                            respuesta4txt.Text.Trim(),
                            (int)correctaupdown.Value - 1,
                            asignaturatxt.Text.Trim(),
                            (int)unidadupdown.Value,
                            (int)subunidadupdown.Value
                        );
   
                        gestor.ModificarPregunta(preguntaSeleccionada.PreguntaId, nuevaPregunta);

                        Preguntas = gestor.LeerPreguntas();
                        MostrarPreguntas();

                        MessageBox.Show("Pregunta modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la pregunta seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarPreguntas();
        }
    }
}