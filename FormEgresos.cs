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
    public partial class FormEgresos : Form
    {
        private Repositorio repo;
        public FormEgresos(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void FormEgresos_Load(object sender, EventArgs e)
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

        }

        private void egresobtn_Click(object sender, EventArgs e)
        {
            var fechaEgreso = fechacal.SelectionStart;
            var nuevoStock = (int)stockud.Value;
            var aux = -nuevoStock;
            var observaciones = observacionestxt.Text.Trim();

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
            EgresoStock nuevoEgreso = new EgresoStock
            {
                Fecha = fechaEgreso,
                Cantidad = nuevoStock,
                Lote = Guid.NewGuid(),
                Producto = productoSeleccionado,
                Observacion = observaciones
            };

            // Agregar al repositorio
            repo.AgregarMovimiento(nuevoEgreso);

            MessageBox.Show("Egreso de stock registrado exitosamente.");
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
    }
}
