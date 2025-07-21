using System.Numerics;

namespace proyecto_final_PED
{
    public partial class Form1 : Form
    {

        private Repositorio repo = new();
        public Form1()
        {
            InitializeComponent();
            // List<Producto> preguntas = gestorPreguntas.LeerPreguntas();

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
        /*  private void generadorExambtn_Click(object sender, EventArgs e)
          {
              /*List<Producto> productos = gestorPreguntas.LeerProductos();
              Form3 form3 = new Form3(productos);

              // Mostrar Form3
              form3.Show();
          }*/

        private void generadorArchivosbtn_Click(object sender, EventArgs e)
        {
            /* List<Productos> preguntas = gestorPreguntas.LeerPreguntas();
             List<Examen> examenes = gestorExamenes.LeerExamen();

             Form4 form4 = new Form4(preguntas, examenes);

             // Mostrar Form4
             form4.Show();*/
        }

        private void Correctorbtn_Click(object sender, EventArgs e)
        {
            /*
            List<Productos> preguntas = gestorPreguntas.LeerPreguntas();
            List<Examen> examenes = gestorExamenes.LeerExamen();

            Form5 form5 = new Form5(preguntas, examenes);

            // Mostrar Form4
            form5.Show();
        }

        private void borrardatosbtn_Click(object sender, EventArgs e)
        {
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
            }*/
        }

        
    }
}
