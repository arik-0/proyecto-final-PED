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
    public partial class Form5 : Form
    {
        private Impresion impresion;
        private GestorExamenes gestorExamenes;

        public Form5(List<Pregunta> preguntas, List<Examen> examenes)
        {
            InitializeComponent();
            impresion = new Impresion();
            gestorExamenes = new GestorExamenes(preguntas);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            List<Examen> examenes = gestorExamenes.LeerExamen(); // Leer exámenes desde el gestor
            MostrarExamenes(examenes);
        }

        private void MostrarExamenes(List<Examen> examenes)
        {
            List<Examen> Examenes = gestorExamenes.LeerExamen();

            // Asignar la lista de exámenes al DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = examenes;
        }

        private void examenSeleccionadobtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
            Examen preguntaSeleccionada = filaSeleccionada.DataBoundItem as Examen;
            groupBox1.Enabled = false;
        }
    }
}
