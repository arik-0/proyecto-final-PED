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
            dataGridView1 = new DataGridView();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Examen> guiso = gestorExamenes.LeerExamen();
            MostrarExamenes(guiso);
        }
        private void MostrarExamenes(List<Examen> examenes)
        {
            List<Examen> Examenes = gestorExamenes.LeerExamen();

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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                Examen preguntaSeleccionada = filaSeleccionada.DataBoundItem as Examen;

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
    }
}
