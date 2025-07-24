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
    public partial class SeleccionarProveedorForm : Form
    {
        public Proveedor ProveedorSeleccionado { get; private set; }

        public SeleccionarProveedorForm(List<Proveedor> proveedores)
        {
            InitializeComponent();
            listBox1.DataSource = proveedores;
            listBox1.DisplayMember = "Nombre";
        }
        private void aceptarbtn_Click_1(object sender, EventArgs e)
        {
            ProveedorSeleccionado = listBox1.SelectedItem as Proveedor;
            if (ProveedorSeleccionado == null)
            {
                MessageBox.Show("Seleccioná un proveedor.");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
