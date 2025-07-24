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
    public partial class AgregarRubro : Form
    {
        private Repositorio repo;
        public AgregarRubro(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void generarRubrobtn_Click(object sender, EventArgs e)
        {
            var nombre = nombreRubrotxt.Text;
            var descripcion = descripcionRubrotxt.Text;
            Rubro nuevoRubro = new(nombre, descripcion);
            repo.AgregarRubro(nuevoRubro);
            MessageBox.Show("Se ha agregado el nuevo rubro :-)");
        }

        private void volvermenubtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
