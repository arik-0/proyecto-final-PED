namespace proyecto_final_PED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adminPregbtn_Click(object sender, EventArgs e)
        {
            Form2 nuevoFormulario = new Form2();

            // Mostrar el formulario
            nuevoFormulario.Show();
        }
    }
}
