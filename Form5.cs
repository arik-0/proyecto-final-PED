using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace proyecto_final_PED
{
    public partial class Form5 : Form
    {
        private Repositorio repo;
        public Form5(Repositorio repo)
        {
            InitializeComponent();
            this.repo = repo;
        }
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void ingresobtn_Click(object sender, EventArgs e)
        {
            FormIngresos formIngresos = new(repo);
            formIngresos.Show();
        }

        private void egresobtn_Click(object sender, EventArgs e)
        {
            FormEgresos formEgresos = new(repo);
            formEgresos.Show();
        }

        private void consultaMovimientosbtn_Click(object sender, EventArgs e)
        {
            ConsultarMovimientos consultaMovimientos = new ConsultarMovimientos(repo);
            consultaMovimientos.Show();
        }
    }
}
