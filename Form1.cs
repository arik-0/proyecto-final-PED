using System.Numerics;

namespace proyecto_final_PED
{
    public partial class Form1 : Form
    {

        GestorPreguntas gestorPreguntas = new GestorPreguntas();

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

        private void generadorExambtn_Click(object sender, EventArgs e)
        {
            List<Pregunta> preguntas = gestorPreguntas.LeerPreguntas(); // Obtén las preguntas de Form1

            // Crear una nueva instancia de Form3 y pasar las preguntas
            Form3 form3 = new Form3(preguntas);

            // Mostrar Form3
            form3.Show();
        }
    }
}
