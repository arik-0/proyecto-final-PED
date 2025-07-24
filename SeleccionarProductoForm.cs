using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_final_PED
{
    public partial class SeleccionarProductoForm : Form
    {
        public Producto ProductoSeleccionado { get; private set; }

        public SeleccionarProductoForm(List<Producto> productos)
        {
            InitializeComponent();
            listBox1.DataSource = productos;
            listBox1.DisplayMember = "Nombre";
        }

        private void aceptarbtn_Click(object sender, EventArgs e)
        {
            ProductoSeleccionado = listBox1.SelectedItem as Producto;
            if (ProductoSeleccionado == null)
            {
                MessageBox.Show("Seleccioná un producto.");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
