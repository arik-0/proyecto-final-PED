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
    public partial class ConsultaProveedor : Form
    {
        private Repositorio repo;
        public ConsultaProveedor(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void ConsultaProveedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ObtenerProveedores();
        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            var nombre = nombreProvtxt.Text.Trim();
            List<Proveedor> proveedor = repo.BuscarProveedorPorNombre(nombre);
            dataGridView1 .DataSource = proveedor;
        }
    }
}
