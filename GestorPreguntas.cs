using ProyectoFinal;

namespace proyecto_final_PED
{

    public class GestorPreguntas
    {
        private string archivoPreguntas = "Preguntas.txt";
        public List<Pregunta> Preguntas { get; private set; }
        private int ultimoId;

        public GestorPreguntas()
        {
            Preguntas = new List<Pregunta>();
            Preguntas = LeerPreguntas();
            // ultimoId = Preguntas.Count > 0 ? Preguntas.Max(p => p.PreguntaId) : 0; // Establecer el último ID usado
        }



        public void EliminarPregunta(Guid preguntaId)
        {
            Preguntas.RemoveAll(p => p.PreguntaId == preguntaId);
            GuardarTodasLasPreguntas();
        }

        public void GuardarPreguntas(Pregunta unaPregunta)
        {
            // Verificar si el archivo no existe y crearlo vacío
            if (!File.Exists(archivoPreguntas))
            {
                using (File.Create(archivoPreguntas)) { }
            }

            // Escribir en el archivo
            using (StreamWriter writer = new StreamWriter(archivoPreguntas, true))
            {
                writer.WriteLine(unaPregunta.GenerarRegistro());
            }
            LeerPreguntas();
        }

        public void GuardarTodasLasPreguntas()
        {
            using (StreamWriter writer = new StreamWriter(archivoPreguntas, false)) // Sobrescribe el archivo
            {
                foreach (var pregunta in Preguntas)
                {
                    writer.WriteLine(pregunta.GenerarRegistro());
                }
            }
            LeerPreguntas();
        }

        public List<Pregunta> LeerPreguntas()
        {
            /* using (StreamWriter writer = new StreamWriter(archivoPreguntas, false)) // 'false' sobrescribe el archivo
             {
                 // El archivo se sobrescribe vacío
                 writer.Write(string.Empty);
             }*/
            List<Pregunta> lista = new List<Pregunta>();

            if (File.Exists(archivoPreguntas))
            {
                using (StreamReader reader = new StreamReader(archivoPreguntas))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        lista.Add(new Pregunta(linea));
                    }
                }
            }

            return lista;
        }

    }
}