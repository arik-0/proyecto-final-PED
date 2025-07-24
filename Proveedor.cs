using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_PED
{
    using System;
    using System.Web;

    namespace proyecto_final_PED
    {
        public class Proveedor
        {
            // Atributos privados
            private Guid id;
            private string nombre;
            private string contacto;
            private string telefono;
            private string direccion;

            // Propiedad pública de solo lectura: ID único
            public Guid Id
            {
                get => id;
                private set => id = value;
            }

            // Propiedades públicas con validaciones
            public string Nombre
            {
                get => nombre;
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("El nombre del proveedor no puede estar vacío.");
                    nombre = value;
                }
            }

            public string Contacto
            {
                get => contacto;
                set => contacto = value ?? "";
            }

            public string Telefono
            {
                get => telefono;
                set => telefono = value ?? "";
            }

            public string Direccion
            {
                get => direccion;
                set => direccion = value ?? "";
            }

            // Constructor sin parámetros, pero inicializa el ID automáticamente
            public Proveedor(string nombre, string telefono, string contacto, string direccion)
            {
                Id = Guid.NewGuid(); // genera un identificador único automáticamente
                Nombre = nombre;
                Contacto = contacto;
                Telefono = telefono;
                Direccion = direccion;
            }
            internal Proveedor()
            {
                Id = Guid.NewGuid(); // lo sobreescribimos al cargar
            }


            // ToString() para mostrar en listas
            public override string ToString()
            {
                return Nombre;
            }
        }
    }

}
