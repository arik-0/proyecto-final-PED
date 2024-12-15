using System.Numerics;

namespace proyecto_final_PED
{
    public partial class Form1 : Form
    {

        GestorPreguntas gestorPreguntas = new GestorPreguntas();
        GestorExamenes gestorExamenes;
        private string archivoPreguntas = "Preguntas.txt";
        private string archivoExamenes = "Examenes.txt";
        private string archivoCorrecciones = "Correcciones.txt";
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

        private void Correctorbtn_Click(object sender, EventArgs e)
        {
            List<Pregunta> preguntas = gestorPreguntas.LeerPreguntas();
            List<Examen> examenes = gestorExamenes.LeerExamen();

            Form5 form5 = new Form5(preguntas, examenes);

            // Mostrar Form4
            form5.Show();
        }

        private void borrardatosbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se han borrado todos los datos.");

            DialogResult resultado = MessageBox.Show(
                $"¿Deseas borrar todos los datos?",
                "Confirmación de destruccion",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                using (StreamWriter writer = new StreamWriter(archivoPreguntas, false))
                {
                    // El archivo se sobrescribe vacío
                    writer.Write(string.Empty);
                }
                using (StreamWriter writer = new StreamWriter(archivoExamenes, false))
                {
                    // El archivo se sobrescribe vacío
                    writer.Write(string.Empty);
                }
                using (StreamWriter writer = new StreamWriter(archivoCorrecciones, false))
                {
                    // El archivo se sobrescribe vacío
                    writer.Write(string.Empty);
                }
                MessageBox.Show("Se han borrado todos los datos.");
            }
            else
            {
                MessageBox.Show("aaaaa te cagaste");
            }
        }
    }
}
