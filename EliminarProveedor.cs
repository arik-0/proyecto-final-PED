using proyecto_final_PED.proyecto_final_PED;
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
    public partial class EliminarProveedor : Form
    {
        private Repositorio repo;
        public EliminarProveedor(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void EliminarProveedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ObtenerProveedores();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                Proveedor proveedorSeleccionado = filaSeleccionada.DataBoundItem as Proveedor;

                if (proveedorSeleccionado != null)
                {
                    // Confirmar la eliminación con el usuario
                    DialogResult resultado = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar la pregunta con ID {proveedorSeleccionado.Id}?",
                        "Confirmación de eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar la pregunta utilizando el gestor
                        repo.EliminarProveedor(proveedorSeleccionado.Id);

                        // Refrescar la lista y la grilla
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = repo.ObtenerProductos();

                        MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el Proveedor seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void eliminarProveedorbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                Proveedor proveedorSeleccionado = filaSeleccionada.DataBoundItem as Proveedor;

                if (proveedorSeleccionado != null)
                {
                    // Confirmar la eliminación con el usuario
                    DialogResult resultado = MessageBox.Show(
                        $"¿Estás seguro de que deseas eliminar la pregunta con ID {proveedorSeleccionado.Id}?",
                        "Confirmación de eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        // Eliminar la pregunta utilizando el gestor
                        repo.EliminarProveedor(proveedorSeleccionado.Id);

                        // Refrescar la lista y la grilla
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = repo.ObtenerProveedores();

                        MessageBox.Show("Proveedor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el Proveedor seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
