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
    public partial class AgregarProveedor : Form
    {
        private Repositorio repo;
        public AgregarProveedor(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }

        private void agregarProveedorbtn_Click(object sender, EventArgs e)
        {
            var nombre = nombretxt.Text.Trim();
            var telefono = telefonotxt.Text.Trim();
            var contacto = contactotxt.Text.Trim();
            var direccion = direcciontxt.Text.Trim();
            Proveedor nuevoProveedor = new(nombre, telefono, contacto, direccion);
            repo.AgregarProveedor(nuevoProveedor);
        }
    }
}
