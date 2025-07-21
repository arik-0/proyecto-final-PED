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
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            var nombreProductoABuscar = nombreProdtxt.Text;
            List<Producto> productosDeEseNombre = repo.BuscarProductoPorNombre(nombreProductoABuscar);
            dataGridView1.DataSource= productosDeEseNombre;
        }
    }
}
