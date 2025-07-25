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
    public partial class FormReportes : Form
    {
        private Repositorio repo;
        public FormReportes(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void stockActualPorProdbtn_Click(object sender, EventArgs e)
        {
            var productos = repo.ObtenerProductos();
            new ImpresoraGenerica().ImprimirStockPorProducto(productos);
            MessageBox.Show("Reporte generado en el bin");
        }

        private void stockPorRubrobtn_Click(object sender, EventArgs e)
        {
            var productos = repo.ObtenerProductos();
            var rubros = repo.ObtenerRubros();
            new ImpresoraGenerica().ImprimirStockPorRubro(productos, rubros);
            MessageBox.Show("Reporte generado en el bin");
        }

        private void MovimientosPorProvbtn_Click(object sender, EventArgs e) //otro Form
        {
            var formSel = new SeleccionarProveedorForm(repo.ObtenerProveedores());
            if (formSel.ShowDialog() == DialogResult.OK)
            {
                var proveedor = formSel.ProveedorSeleccionado;
                var ingresos = repo.ObtenerMovimientos()
                                   .OfType<IngresoStock>()
                                   .Where(m => m.Proveedor?.Nombre == proveedor.Nombre)
                                   .ToList();

                new ImpresoraGenerica().ImprimirMovimientosPorProveedor(ingresos);
                MessageBox.Show("Reporte generado correctamente.");
            }
        }
        private void objetosConBajoStockbtn_Click(object sender, EventArgs e)
        {
            int umbralMinimo = 10; // o configurable
            var productosBajoStock = repo.ObtenerProductos()
                                          .Where(p => p.Stock < umbralMinimo)
                                          .ToList();

            if (productosBajoStock.Count == 0)
            {
                MessageBox.Show("No hay productos con bajo stock.");
                return;
            }

            new ImpresoraGenerica().ImprimirProductosConBajoStock(productosBajoStock, umbralMinimo);
            MessageBox.Show("Reporte generado correctamente.");
        }

        private void historialDeMovimientosPorProdbtn_Click(object sender, EventArgs e) // Otro form
        {
            var formSel = new SeleccionarProductoForm(repo.ObtenerProductos());
            if (formSel.ShowDialog() == DialogResult.OK)
            {
                var producto = formSel.ProductoSeleccionado;
                var movimientos = repo.ObtenerMovimientos()
                                       .Where(m => m.Producto.Codigo == producto.Codigo)
                                       .ToList();

                new ImpresoraGenerica().ImprimirHistorialMovimientosProducto(producto.Nombre, movimientos);
                MessageBox.Show("Reporte generado correctamente.");
            }
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
