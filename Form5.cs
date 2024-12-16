using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_final_PED
{
    public partial class Form5 : Form
    {
        private GestorPreguntas gestorPreguntas;
        private GestorExamenes gestorExamenes;
        private GestorCorrecciones correcciones;
        private int indicePreguntaActual = 0;
        private Guid preguntaIdActual;

        public Form5(List<Pregunta> preguntas, List<Examen> examenes)
        {
            InitializeComponent();
            gestorPreguntas = new GestorPreguntas();
            gestorExamenes = new GestorExamenes(preguntas);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
            List<Examen> examenes = gestorExamenes.LeerExamen();
            MostrarExamenes(examenes);
        }

        private void MostrarExamenes(List<Examen> examenes)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = examenes;
        }

        private void examenSeleccionadobtn_Click(object sender, EventArgs e)
        {

            string nombreAlumno = apeynomtxt.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreAlumno))
            {
                MessageBox.Show("Por favor, ingrese el nombre y apellido del alumno.", "Error");
                return;
            }


            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            Examen examenSeleccionado = filaSeleccionada.DataBoundItem as Examen;

            if (examenSeleccionado != null && examenSeleccionado.IdPreguntas.Any())
            {

                List<Pregunta> preguntasExamen = gestorPreguntas.LeerPreguntas()
                    .Where(p => examenSeleccionado.IdPreguntas.Contains(p.PreguntaId))
                    .ToList();

                correcciones = new GestorCorrecciones(preguntasExamen, apeynomtxt.Text.Trim(), examenSeleccionado.ExamenId);

                groupBox2.Enabled = true;
                groupBox1.Enabled = false;

                indicePreguntaActual = 0;
                groupBox2.Text = examenSeleccionado.ExamenId.ToString();

                MostrarPreguntaActual();
            }
            else
            {
                MessageBox.Show("El examen seleccionado no tiene preguntas asociadas.");
            }
        }

        private void MostrarPreguntaActual()
        {

            var (txtPregunta, idPregunta) = correcciones.MostrarPreguntaActual();


            if (idPregunta != Guid.Empty)
            {

                labelTituloPregunta.Text = $"Pregunta: {txtPregunta}";
                idPreguntalbl.Text = $"ID: {idPregunta}";
                preguntaIdActual = idPregunta;

                respuestaUpDown.Value = 1;
            }
            else
            {
                MessageBox.Show("Has terminado el examen.");
                FinalizarExamen();
            }
        }



        private void GuardarCorreccion()
        {

            string alumno = apeynomtxt.Text.Trim();


            correcciones.GuardarCorreccion();


            MessageBox.Show($"Los resultados de {alumno} han sido guardados correctamente.");
        }

        private void FinalizarExamen()
        {

            MessageBox.Show($"¡Examen finalizado! Tu puntuación es: {correcciones.CalcularPuntuacion()}");
            correcciones.GuardarCorreccion();

            groupBox2.Enabled = false;
            groupBox1.Enabled = true;

            indicePreguntaActual = 0;
            labelTituloPregunta.Text = "Pregunta:";
            idPreguntalbl.Text = "ID:";
        }

        private void siguientePreguntabtn_Click_1(object sender, EventArgs e)
        {

            int respuestaAlumno = (int)respuestaUpDown.Value - 1;


            bool esCorrecta = correcciones.VerificarRespuesta(preguntaIdActual, respuestaAlumno);

            string resultado = esCorrecta ? "Correcta" : "Incorrecta";
            MessageBox.Show($"Respuesta {resultado}", "Resultado de la pregunta");

            correcciones.AvanzarPregunta();

            if (correcciones.HayMasPreguntas())
            {
                MostrarPreguntaActual();
            }
            else
            {
                MessageBox.Show("No hay más preguntas. Finalizando el examen.");

                FinalizarExamen();
            }
        }

        private void finalizarcorreccionbtn_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show($"Tu puntuación final es: {correcciones.CalcularPuntuacion()}");

            GuardarCorreccion();

            FinalizarExamen();
        }

        private void volvermenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
