using proyecto_final_PED;
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
    public partial class Form3 : Form
    {
        private List<Pregunta> Preguntas;
        private GestorExamenes gestorExamenes;

        public Form3(List<Pregunta> preguntas)
        {
            InitializeComponent();
            Preguntas = preguntas; // Asignamos las preguntas pasadas desde Form1
            gestorExamenes = new GestorExamenes(Preguntas); // Inicializamos el gestor de exámenes
        }

        private void generarExamenbtn_Click(object sender, EventArgs e)
        {
            // Obtener la asignatura seleccionada
            string asignaturaSeleccionada = asignaturatxt.Text.Trim();

            // Leer el intervalo de unidades desde el TextBox
            string intervaloTexto = unidadesIntervalotxt.Text.Trim();

            // Validar y procesar el intervalo de unidades
            List<int> unidadesSeleccionadas = ProcesarIntervaloDeUnidades(intervaloTexto);

            if (unidadesSeleccionadas.Count == 0)
            {
                MessageBox.Show("El intervalo de unidades no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            GestorExamenes gestorExamenes = new GestorExamenes(Preguntas);
            Examen examenGenerado = gestorExamenes.GenerarExamen(asignaturaSeleccionada, unidadesSeleccionadas);

            
            MessageBox.Show($"Examen generado con ID: {examenGenerado.ExamenId} para la asignatura: {examenGenerado.Asignatura}",
                            "Examen Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<int> ProcesarIntervaloDeUnidades(string intervaloTexto)
        {
            List<int> unidades = new List<int>();

            
            if (intervaloTexto.Contains("-"))
            {
                
                string[] partes = intervaloTexto.Split('-');

                
                if (partes.Length == 2)
                {
                    
                    if (int.TryParse(partes[0], out int inicio) && int.TryParse(partes[1], out int fin))
                    {
                        
                        if (inicio <= fin)
                        {
                            
                            for (int i = inicio; i <= fin; i++)
                            {
                                unidades.Add(i);
                            }
                        }
                    }
                }
            }

            return unidades;
        }

        private void unidadesIntervalotxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
