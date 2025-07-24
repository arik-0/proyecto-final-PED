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
        private Repositorio repo;

        public Form4(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }



        private void volverAlMenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarProveedorbtn_Click(object sender, EventArgs e)
        {
            AgregarProveedor agregarProveedor = new(repo);
            agregarProveedor.Show();
        }

        private void eliminarProveedorbtn_Click(object sender, EventArgs e)
        {
            EliminarProveedor eliminarProveedor = new(repo);
            eliminarProveedor.Show();
        }

        private void modificarProveedorbtn_Click(object sender, EventArgs e)
        {
            ModificarProveedor modificarProveedor = new(repo);
            modificarProveedor.Show();
        }

        private void consultarProveedoresbtn_Click(object sender, EventArgs e)
        {
            ConsultaProveedor consultaProveedor = new(repo);
            consultaProveedor.Show();
        }
    }
}
/* private void generarImpresionbtn_Click(object sender, EventArgs e)
        {
            string datosuni = datosUniversidadtxt.Text.Trim();
            string carrera = carreratxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(datosuni) || string.IsNullOrWhiteSpace(carrera))
            {
                MessageBox.Show("Por favor, complete los datos de la universidad y la carrera.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];

                if (filaSeleccionada.Cells["ExamenId"].Value != null)
                {
                    string examenIdString = filaSeleccionada.Cells["ExamenId"].Value.ToString();

                    if (Guid.TryParse(examenIdString, out Guid examenId))
                    {
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
            }*/