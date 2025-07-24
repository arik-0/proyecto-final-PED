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
    public partial class ModificarRubro : Form
    {
        private Repositorio repo;
        public ModificarRubro(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void ModificarRubro_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = repo.ObtenerRubros();
        }

        private void modificarRubrobtn_Click(object sender, EventArgs e)
        {
            try
            {
                var nombre = nombretxt.Text.Trim();
                var descripcion = descripciontxt.Text.Trim();
                Rubro rubroAmodificar = new(nombre, descripcion);
                repo.ModificarRubro(rubroAmodificar);
                MessageBox.Show("El rubro se ha modificado correctamente");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = repo.ObtenerRubros();
            }catch(Exception ex) { }
        }
    }
}
