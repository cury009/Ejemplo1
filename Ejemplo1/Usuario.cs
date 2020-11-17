using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class Usuario
    {
        public String Nombre { get; set; }
        public String Apellido1 { get; set; }
        public String Apellido2 { get; set; }
        public String Direccion { get; set; }
        public String Codigo { get; set; }

        public Usuario(string nombre, string apellido1, string apellido2, string direccion, string codigo)
        {
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            this.Direccion = direccion;
            Codigo = codigo;
        }
    }
}
