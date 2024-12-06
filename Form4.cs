using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_PED
{
    public partial class Form4 : Form
    {
        private Impresion impresion;
        private GestorExamenes gestorExamenes;

        public Form4(List<Pregunta> preguntas, List<Examen> examenes)
        {
            InitializeComponent();
            impresion = new Impresion();
            gestorExamenes = new GestorExamenes(preguntas);
            MostrarExamenes(examenes);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           /* List<Examen> examenes = gestorExamenes.LeerExamen(); // Leer exámenes desde el gestor
            MostrarExamenes(examenes);*/
        }

        private void MostrarExamenes(List<Examen> examenes)
        {
          //  List<Examen> Examenes = gestorExamenes.LeerExamen();

            // Asignar la lista de exámenes al DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = examenes;
        }
        private void volverAlMenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generarImpresionbtn_Click(object sender, EventArgs e)
        {
            string datosuni = datosUniversidadtxt.Text.Trim();
            string carrera = carreratxt.Text.Trim();

            // Validar que haya datos en los campos de texto
            if (string.IsNullOrWhiteSpace(datosuni) || string.IsNullOrWhiteSpace(carrera))
            {
                MessageBox.Show("Por favor, complete los datos de la universidad y la carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                // Obtener el valor de la columna "ExamenId"
                if (filaSeleccionada.Cells["ExamenId"].Value != null)
                {
                    string examenIdString = filaSeleccionada.Cells["ExamenId"].Value.ToString();

                    // Intentar convertir el valor a GUID
                    if (Guid.TryParse(examenIdString, out Guid examenId))
                    {
                        // Llamar al método para generar la impresión
                        impresion.GenerarImpresion(examenId, datosuni, carrera);
                        MessageBox.Show("La impresión se generó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El ID del examen no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El valor del ID del examen está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
