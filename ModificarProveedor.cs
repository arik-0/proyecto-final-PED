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
    public partial class ModificarProveedor : Form
    {
        private Repositorio repo;
        private Proveedor proveedorSeleccionado;

        public ModificarProveedor(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void ModificarProveedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ObtenerProveedores();
        }

        private void modificarRubrobtn_Click(object sender, EventArgs e)
        {
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Seleccioná un proveedor primero.");
                return;
            }

            try
            {
                proveedorSeleccionado.Nombre = nombretxt.Text;
                proveedorSeleccionado.Contacto = contactotxt.Text;
                proveedorSeleccionado.Telefono = telefonotxt.Text;
                proveedorSeleccionado.Direccion = direcciontxt.Text;

                // Reemplazar el proveedor en la lista
                repo.ModificarProveedor(proveedorSeleccionado);

                // Refrescar la grilla
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.ObtenerProveedores();

                MessageBox.Show("Proveedor modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Proveedor proveedor)
            {
                proveedorSeleccionado = proveedor;

                nombretxt.Text = proveedor.Nombre;
                contactotxt.Text = proveedor.Contacto;
                telefonotxt.Text = proveedor.Telefono;
                direcciontxt.Text = proveedor.Direccion;
                
            }
        }
    }
}
