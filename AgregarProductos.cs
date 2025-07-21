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
    public partial class AgregarProductos : Form
    {
        private Repositorio repo;
        public AgregarProductos(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void AgregarProductos_Load(object sender, EventArgs e)
        {
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


        private void agregarProductosbtn_Click(object sender, EventArgs e)
        {
            try
            {
                var nuevoProd = new Producto();
                nuevoProd.Nombre = nombretxt.Text.Trim();
                nuevoProd.Descripcion = descripciontxt.Text.Trim();
                nuevoProd.Stock = (int)stockud.Value;
                nuevoProd.FechaVencimiento = fechavtocal.SelectionStart;
                nuevoProd.PrecioCompra = (float)precioCompraud.Value;

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
                
                repo.AgregarProducto(nuevoProd);
                MessageBox.Show("Producto agregado correctamente.");
                // o limpiar campos
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

    }
}
