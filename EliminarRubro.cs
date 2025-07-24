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
    public partial class EliminarRubro : Form
    {
        private Repositorio repo;
        public EliminarRubro(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ObtenerRubros();
        }

        private void eliminarProductobtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                Rubro rubroSeleccionado = filaSeleccionada.DataBoundItem as Rubro;

                if (rubroSeleccionado != null)
                {
                    // Confirmar la eliminación con el usuario
                    DialogResult resultado = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar el rubro con nombre {rubroSeleccionado.Nombre}?",
                        "Confirmación de eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar la pregunta utilizando el gestor
                        repo.EliminarRubro(rubroSeleccionado.Nombre);

                        // Refrescar la lista y la grilla
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = repo.ObtenerRubros();

                        MessageBox.Show("Rubro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el Rubro seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
