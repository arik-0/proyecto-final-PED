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
    public partial class ConsultarMovimientos : Form
    {
        private Repositorio repo;
        public ConsultarMovimientos(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void rubroslstbx_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void ConsultarMovimientos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            var movimientos = repo.ObtenerMovimientos();
            MostrarMovimientosEnGrilla(movimientos);
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            var nombreProd = nombreProdtxt.Text.Trim();

            List<MovimientoStock> movimientos = repo.BuscarMovimientosPorNombreProducto(nombreProd);

            MostrarMovimientosEnGrilla(movimientos);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  if(Selecte)
        }
        private void MostrarMovimientosEnGrilla(List<MovimientoStock> movimientos)
        {
            var vista = movimientos.Select(m => new
            {
                Fecha = m.Fecha.ToString("dd/MM/yyyy"),
                FechaVencimiento = m is IngresoStock ingreso ? ingreso.FechaVencimiento.ToString("dd/MM/yyyy") : "-",
                Tipo = m.Tipo,
                Producto = m.Producto.Nombre,
                Cantidad = m.Cantidad,
                Observación = m.Observacion,
                Proveedor = m is IngresoStock ingreso2 ? ingreso2.Proveedor.Nombre : "-"
            }).ToList();

            // 🔴 Esto es lo importante para que se refresque la grilla correctamente
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear(); // <--- limpiar columnas
            dataGridView1.DataSource = vista;

            if (vista.Count == 0)
                MessageBox.Show("No se encontraron movimientos con ese filtro.");
        }

        private void buscarPorTipobtn_Click(object sender, EventArgs e)
        {
            string tipoSeleccionado = tipoMovimientolst.SelectedItem?.ToString();

            var movimientos = repo.ObtenerMovimientos();

            if (tipoSeleccionado == "Ingreso")
                movimientos = movimientos.OfType<IngresoStock>().Cast<MovimientoStock>().ToList();
            else if (tipoSeleccionado == "Egreso")
                movimientos = movimientos.OfType<EgresoStock>().Cast<MovimientoStock>().ToList();

            MostrarMovimientosEnGrilla(movimientos);
        }

        private void buscarporfechabtn_Click(object sender, EventArgs e)
        {
            DateTime desde = iniciodebusquedadtp.Value.Date;
            DateTime hasta = findebusquedadtp.Value.Date;

            var movimientos = repo.ObtenerMovimientos()
                .Where(m => m.Fecha.Date >= desde && m.Fecha.Date <= hasta)
                .ToList();

            MostrarMovimientosEnGrilla(movimientos);
        }
    }
}
