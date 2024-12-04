using System.Numerics;

namespace proyecto_final_PED
{
    public partial class Form1 : Form
    {

        GestorPreguntas gestorPreguntas = new GestorPreguntas();
        GestorExamenes gestorExamenes;
        public Form1()
        {
            InitializeComponent();
            List<Pregunta> preguntas = gestorPreguntas.LeerPreguntas();
            gestorExamenes = new GestorExamenes(preguntas);
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
            List<Pregunta> preguntas = gestorPreguntas.LeerPreguntas(); 

            
            Form3 form3 = new Form3(preguntas);

            // Mostrar Form3
            form3.Show();
        }

        private void generadorArchivosbtn_Click(object sender, EventArgs e)
        {
            List<Pregunta> preguntas = gestorPreguntas.LeerPreguntas();
            List<Examen> examenes = gestorExamenes.LeerExamen();

            Form4 form4 = new Form4(preguntas, examenes);

            // Mostrar Form4
            form4.Show();
        }
    }
}
