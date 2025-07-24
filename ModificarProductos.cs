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
    public partial class ModificarProductos : Form
    {
        private Repositorio repo;
        public ModificarProductos(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void ModificarProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ObtenerProductos();
            rubroslstbx.Items.Clear();
            try
            {
                List<Rubro> rubros = repo.ObtenerRubros();

                foreach (var rubro in rubros)
                {
                    rubroslstbx.Items.Add(rubro); // ← Agregás el objeto Rubro, no solo el nombre
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar rubros: {ex.Message}");
            }
        }

        private void modificarProductosbtn_Click(object sender, EventArgs e)
        {
            var codigo = Convert.ToInt32(codigotxt.Text);
            var nombre = nombretxt.Text.Trim();
            var descripcion = descripciontxt.Text.Trim();
            var stock = (int)stockud.Value;
            var precioCompra = (float)precioCompraud.Value;

            if (rubroslstbx.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un rubro.");
                return;
            }

            var rubroSeleccionado = rubroslstbx.CheckedItems[0] as Rubro;

            if (rubroSeleccionado == null)
            {
                MessageBox.Show("Error al obtener el rubro seleccionado.");
                return;
            }
            var nuevoProd = new Producto(codigo, nombre, descripcion, precioCompra, stock, rubroSeleccionado);
            MessageBox.Show("Producto modificado correctamente.");
            repo.ModificarProducto(nuevoProd);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ObtenerProductos();
        }

        private void rubroslstbx_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int i = 0; i < rubroslstbx.Items.Count; i++)
            {
                if (i != e.Index)
                {
                    rubroslstbx.SetItemChecked(i, false);
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Producto producto)
            {
                Producto productoSeleccionado = producto;

                nombretxt.Text = producto.Nombre;
                descripciontxt.Text = producto.Descripcion;
                stockud.Value = productoSeleccionado.Stock;
                precioCompraud.Value = (int)productoSeleccionado.PrecioCompra;
                // Primero desmarcar todos
                for (int i = 0; i < rubroslstbx.Items.Count; i++)
                {
                    rubroslstbx.SetItemChecked(i, false);
                }

                // Luego marcar el que coincide
                for (int i = 0; i < rubroslstbx.Items.Count; i++)
                {
                    if (rubroslstbx.Items[i] is Rubro rubro &&
                        rubro.Nombre == productoSeleccionado.Rubro.Nombre)
                    {
                        rubroslstbx.SetItemChecked(i, true);
                        break;
                    }
                }

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
