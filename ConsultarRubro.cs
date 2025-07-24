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
    public partial class ConsultarRubro : Form
    {
        private Repositorio repo;
        public ConsultarRubro(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void ConsultarRubro_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.DataSource = repo.ObtenerRubros();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
