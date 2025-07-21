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
            var fechaVencimiento = fechavtocal.SelectionStart;
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
            var nuevoProd = new Producto(codigo, nombre, descripcion, precioCompra, stock, rubroSeleccionado, fechaVencimiento);
            MessageBox.Show("Producto modificado correctamente.");
            repo.ModificarProducto(nuevoProd);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ObtenerProductos();
        }
    }
}
