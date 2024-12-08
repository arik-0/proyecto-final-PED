using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proyecto_final_PED
{
    public partial class Form5 : Form
    {
        private Impresion impresion;
        private GestorExamenes gestorExamenes;
        private GestorCorrecciones gestorCorrecciones;
        private List<Pregunta> preguntas;
        private Guid preguntaIdActual;
        private int indicePreguntaActual = 0;

        public Form5(List<Pregunta> preguntas, List<Examen> examenes)
        {
            InitializeComponent();
            impresion = new Impresion();
            gestorExamenes = new GestorExamenes(preguntas);
            this.preguntas = preguntas;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
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
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un examen.", "Error");
                return;
            }

            // Obtener la fila seleccionada
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

            // Intentar obtener el examen de la fila seleccionada
            Examen examenSeleccionado = filaSeleccionada.DataBoundItem as Examen;

            if (examenSeleccionado == null)
            {
                MessageBox.Show("El examen seleccionado no es válido.", "Error");
                return;
            }

            // Convertir los GUIDs de IdPreguntas a objetos Pregunta
            List<Pregunta> preguntasDelExamen = new List<Pregunta>();
            foreach (var preguntaId in examenSeleccionado.IdPreguntas)
            {
                // Buscar cada Pregunta por su ID
                var pregunta = preguntas.FirstOrDefault(p => p.PreguntaId == preguntaId);
                if (pregunta != null)
                {
                    preguntasDelExamen.Add(pregunta);
                }
            }

            if (preguntasDelExamen.Count == 0)
            {
                MessageBox.Show("No se encontraron preguntas asociadas a este examen.", "Error");
                return;
            }

            // Inicializar el GestorCorrecciones con las preguntas del examen
            gestorCorrecciones = new GestorCorrecciones(preguntasDelExamen);

            groupBox1.Enabled = true; // Habilitar el grupo de preguntas
            MostrarPreguntaActual();
        }

        private void MostrarPreguntaActual()
        {
            var (tituloPregunta, idPregunta) = gestorCorrecciones.MostrarPreguntaActual(indicePreguntaActual);

            if (idPregunta != Guid.Empty)
            {
                preguntaLabel.Text = tituloPregunta;
                preguntaIdActual = idPregunta;
                respuestaNumericUpDown.Value = 0; // Restablecer la respuesta anterior
            }
            else
            {
                MessageBox.Show("Has terminado el examen.");
                FinalizarExamen();
            }
        }

        private void siguienteBtn_Click(object sender, EventArgs e)
        {
            int respuestaAlumno = (int)respuestaNumericUpDown.Value;

            bool respuestaCorrecta = gestorCorrecciones.VerificarRespuesta(preguntaIdActual, respuestaAlumno);

            string resultado = respuestaCorrecta ? "Correcta" : "Incorrecta";
            MessageBox.Show($"Respuesta {resultado}", "Resultado de la pregunta");

            // Mover al siguiente pregunta, solo si hay más preguntas
            indicePreguntaActual++;
            if (indicePreguntaActual < preguntas.Count)
            {
                MostrarPreguntaActual();
            }
            else
            {
                FinalizarExamen();
            }
        }

        private void FinalizarExamen()
        {
            int puntuacionFinal = gestorCorrecciones.CalcularPuntuacion();
            MessageBox.Show($"Tu puntuación final es {puntuacionFinal} de {preguntas.Count}.");

            string alumno = "Nombre del Alumno"; // Aquí deberías obtener el nombre del alumno
            Guid examenId = Guid.NewGuid(); // Aquí obtén el ID real del examen
            gestorCorrecciones.GuardarCorreccion(alumno, examenId, puntuacionFinal);
        }
    }
}
