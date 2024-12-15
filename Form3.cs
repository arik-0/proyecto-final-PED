using proyecto_final_PED;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_PED
{
    public partial class Form3 : Form
    {
        private List<Pregunta> Preguntas;
        private GestorExamenes gestorExamenes;

        public Form3(List<Pregunta> preguntas)
        {
            InitializeComponent();
            Preguntas = preguntas;
            gestorExamenes = new GestorExamenes(Preguntas);
        }

        private void generarExamenbtn_Click(object sender, EventArgs e)
        {
            string asignaturaSeleccionada = asignaturatxt.Text.Trim().ToUpper();

            string intervaloTexto = unidadesIntervalotxt.Text.Trim();

            DateTime fechaexamen = fechaexamencal.SelectionStart;

            List<int> unidadesSeleccionadas = ProcesarUnidades(intervaloTexto);

            if (unidadesSeleccionadas.Count == 0)
            {
                MessageBox.Show("El intervalo de unidades no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            GestorExamenes gestorExamenes = new GestorExamenes(Preguntas);
            Examen examenGenerado = gestorExamenes.GenerarExamen(asignaturaSeleccionada, unidadesSeleccionadas, fechaexamen);



            MessageBox.Show($"Examen generado con ID: {examenGenerado.ExamenId} para la asignatura: {examenGenerado.Asignatura}", "Examen Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<int> ProcesarUnidades(string unidadesTexto)
        {
            List<int> unidades = new List<int>();

            if (string.IsNullOrWhiteSpace(unidadesTexto))
            {
                return unidades;
            }

            string[] unidadesArray = unidadesTexto.Split('/');

            foreach (var unidad in unidadesArray)
            {
                if (int.TryParse(unidad.Trim(), out int unidadNumerica))
                {
                    unidades.Add(unidadNumerica);
                }
                else
                {
                    MessageBox.Show($"La unidad '{unidad}' no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return new List<int>();
                }
            }
            return unidades;
        }

        private void volvermenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
