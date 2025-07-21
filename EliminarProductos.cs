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
    public partial class EliminarProductos : Form
    {
        private Repositorio repo;
        public EliminarProductos(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void EliminarProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ObtenerProductos();
        }
    }
}
