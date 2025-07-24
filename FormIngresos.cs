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
    public partial class FormIngresos : Form
    {
        private Repositorio repo;
        public FormIngresos(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void FormIngresos_Load(object sender, EventArgs e)
        {

            var productos = repo.ObtenerProductos();

            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = productos;

            // Limpiar columnas previas (opcional si lo hacés una sola vez)
            dataGridView1.Columns.Clear();

            // Crear columnas visibles: solo Nombre y Stock
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                ReadOnly = true
            });

            try
            {
                List<Proveedor> proveedores = repo.ObtenerProveedores();
                proveedoreslstbx.Items.Clear();
                foreach (var proveedor in proveedores)
                {
                    proveedoreslstbx.Items.Add(proveedor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}");
            }


        }

        private void ingresarbtn_Click(object sender, EventArgs e)
        {
            var fechaVencimiento = fechavtocal.SelectionStart;
            var nuevoStock = (int)stockud.Value;

            // Validar proveedor seleccionado
            if (proveedoreslstbx.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un Proveedor.");
                return;
            }

            var proveedorSeleccionado = proveedoreslstbx.CheckedItems[0] as Proveedor;
            if (proveedorSeleccionado == null)
            {
                MessageBox.Show("Error al obtener el Proveedor seleccionado.");
                return;
            }

            // Validar producto seleccionado
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto desde la tabla.");
                return;
            }

            var productoSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Producto;
            if (productoSeleccionado == null)
            {
                MessageBox.Show("Error al obtener el producto desde la grilla.");
                return;
            }

            // Crear el movimiento
            IngresoStock nuevoIngreso = new IngresoStock
            {
                FechaVencimiento = fechaVencimiento, 
                Fecha = DateTime.Now,
                Cantidad = nuevoStock,
                Lote = Guid.NewGuid(),
                Producto = productoSeleccionado,
                Proveedor = proveedorSeleccionado,
                Observacion = "Ingreso desde formulario"
            };

            // Agregar al repositorio
            repo.AgregarMovimiento(nuevoIngreso);

            MessageBox.Show("Ingreso de stock registrado exitosamente.");
            var productos = repo.ObtenerProductos();

            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = productos;

            // Limpiar columnas previas (opcional si lo hacés una sola vez)
            dataGridView1.Columns.Clear();

            // Crear columnas visibles: solo Nombre y Stock
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                ReadOnly = true
            });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
