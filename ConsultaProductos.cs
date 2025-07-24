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
    public partial class ConsultaProductos : Form
    {
        private Repositorio repo;
        public ConsultaProductos(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void ConsultaProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = repo.ObtenerProductos();
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

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            string nombreProducto = nombreProdtxt.Text.Trim();
            bool hayNombre = !string.IsNullOrWhiteSpace(nombreProducto);
            bool hayRubroSeleccionado = rubroslstbx.CheckedItems.Count > 0;

            List<Producto> resultado = new List<Producto>();

            if (hayNombre && hayRubroSeleccionado)
            {
                // Búsqueda combinada por nombre y rubro
                foreach (var item in rubroslstbx.CheckedItems)
                {
                    string rubro = item.ToString();
                    var productosPorRubro = repo.BuscarProductosPorNombreDeRubro(rubro);
                    var filtrados = productosPorRubro
                        .Where(p => p.Nombre.Contains(nombreProducto, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    resultado.AddRange(filtrados);
                }
            }
            else if (hayNombre)
            {
                resultado = repo.BuscarProductoPorNombre(nombreProducto);
            }
            else if (hayRubroSeleccionado)
            {
                foreach (var item in rubroslstbx.CheckedItems)
                {
                    string rubro = item.ToString();
                    var productosPorRubro = repo.BuscarProductosPorNombreDeRubro(rubro);
                    resultado.AddRange(productosPorRubro);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre o seleccione al menos un rubro para buscar.");
                return;
            }

            // Eliminar duplicados si hubo combinación de criterios
            resultado = resultado.Distinct().ToList();

            // Mostrar resultados en el DataGridView
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = resultado;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {
            if (!groupBox2.Enabled)
            {
                groupBox3.Enabled = false;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (!groupBox3.Enabled)
            {
                groupBox2.Enabled = false;
            }
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
    }
}
