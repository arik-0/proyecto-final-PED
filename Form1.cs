using System.Numerics;

namespace proyecto_final_PED
{
    public partial class Form1 : Form
    {

        private Repositorio repo = new();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void gestionProdbtn_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(repo);

            // Mostrar el formulario
            form2.Show();
        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void gestionRubrosbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(repo);
            form3.Show();
        }

        private void gestionProveedoresbtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new(repo);
            form4.Show();
        }

        private void gestionMovimientosbtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new(repo);
            form5.Show();
        }

        private void reportesbtn_Click(object sender, EventArgs e)
        {
            FormReportes formReportes = new(repo);
            formReportes.Show();
        }
    }
}
