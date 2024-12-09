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
        private int indicePreguntaActual = 0; // Índice de la pregunta actual
        private Guid preguntaIdActual;

        public Form5(List<Pregunta> preguntas, List<Examen> examenes)
        {
            InitializeComponent();
            gestorPreguntas = new GestorPreguntas();
            gestorExamenes = new GestorExamenes(preguntas);
            this.preguntas = preguntas;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
            List<Examen> examenes = gestorExamenes.LeerExamen(); // Leer exámenes desde el gestor
            MostrarExamenes(examenes);
        }

        private void MostrarExamenes(List<Examen> examenes)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = examenes;
        }

        private void examenSeleccionadobtn_Click(object sender, EventArgs e)
        {
            // Validar que el nombre del alumno esté ingresado
            string nombreAlumno = apeynomtxt.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombreAlumno))
            {
                MessageBox.Show("Por favor, ingrese el nombre y apellido del alumno.", "Error");
                return;
            }

            // Obtener el examen seleccionado
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            Examen examenSeleccionado = filaSeleccionada.DataBoundItem as Examen;

            if (examenSeleccionado != null && examenSeleccionado.IdPreguntas.Any())
            {
                // Filtrar las preguntas asociadas al examen
                List<Pregunta> preguntasExamen = gestorPreguntas.LeerPreguntas()
                    .Where(p => examenSeleccionado.IdPreguntas.Contains(p.PreguntaId))
                    .ToList();

                // Inicializar GestorCorrecciones con la lista de preguntas filtrada
                correcciones = new GestorCorrecciones(preguntasExamen, apeynomtxt.Text.Trim(), examenSeleccionado.ExamenId);

                // Habilitar la sección de preguntas
                groupBox2.Enabled = true;
                groupBox1.Enabled = false;

                // Inicializar el índice de la pregunta actual
                indicePreguntaActual = 0;
                groupBox2.Text = examenSeleccionado.ExamenId.ToString();
                // Muestra la primera pregunta
                MostrarPreguntaActual();
            }
            else
            {
                MessageBox.Show("El examen seleccionado no tiene preguntas asociadas.");
            }
        }

        private void MostrarPreguntaActual()
        {
            // Usamos el método de GestorCorrecciones para mostrar la pregunta actual basada en el índice
            var (txtPregunta, idPregunta) = correcciones.MostrarPreguntaActual();

            // Comprobamos si la pregunta existe
            if (idPregunta != Guid.Empty)
            {
                // Mostrar el texto de la pregunta y el ID en los labels
                labelTituloPregunta.Text = $"Pregunta: {txtPregunta}";
                idPreguntalbl.Text = $"ID: {idPregunta}";
                preguntaIdActual = idPregunta; // Guardamos el ID de la pregunta actual

                // Resetear el valor del UpDown para la respuesta
                respuestaUpDown.Value = 0;
               // MessageBox.Show(txtPregunta);
            }
            else
            {
                MessageBox.Show("Has terminado el examen.");
                FinalizarExamen();
            }
        }



        private void GuardarCorreccion()
        {
            // Obtener el nombre del alumno
            string alumno = apeynomtxt.Text.Trim();

            // Guardar la corrección en el archivo
            correcciones.GuardarCorreccion();

            // Mostrar un mensaje de éxito
            MessageBox.Show($"Los resultados de {alumno} han sido guardados correctamente.");
        }

        private void FinalizarExamen()
        {
            // Aquí podrías mostrar la puntuación final del alumno
            MessageBox.Show($"¡Examen finalizado! Tu puntuación es: {correcciones.CalcularPuntuacion()}");

            // Deshabilitar la sección de preguntas
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
            // Reiniciar el índice y limpiar las etiquetas
            indicePreguntaActual = 0;
            labelTituloPregunta.Text = "Pregunta:";
            idPreguntalbl.Text = "ID:";
        }

        private void siguientePreguntabtn_Click_1(object sender, EventArgs e)
        {
            // Obtener la respuesta del alumno
            int respuestaAlumno = (int)respuestaUpDown.Value;

            // Verificar si la respuesta es correcta
            bool esCorrecta = correcciones.VerificarRespuesta(preguntaIdActual, respuestaAlumno);

            string resultado = esCorrecta ? "Correcta" : "Incorrecta";
            MessageBox.Show($"Respuesta {resultado}", "Resultado de la pregunta");

            // Avanzar a la siguiente pregunta
            correcciones.AvanzarPregunta();

            // Verificar si hay más preguntas
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
            // Mostrar la puntuación final al alumno
            MessageBox.Show($"Tu puntuación final es: {correcciones.CalcularPuntuacion()}");

            // Guardar la corrección en un archivo de texto (correcciones.txt)
            GuardarCorreccion();

            // Finalizar el examen
            FinalizarExamen();
        }

        private void volvermenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
