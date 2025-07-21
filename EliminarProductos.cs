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
    public partial class EliminarProductos : Form
    {
        private Repositorio repo;
        public EliminarProductos(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void EliminarProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ObtenerProductos();
        }

        private void eliminarProductobtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                Producto productoSeleccionado = filaSeleccionada.DataBoundItem as Producto;

                if (productoSeleccionado != null)
                {
                    // Confirmar la eliminación con el usuario
                    DialogResult resultado = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar la pregunta con ID {productoSeleccionado.Codigo}?",
                        "Confirmación de eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar la pregunta utilizando el gestor
                        repo.EliminarProducto(productoSeleccionado.Codigo);

                        // Refrescar la lista y la grilla
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = repo.ObtenerProductos();

                        MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el producto seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
