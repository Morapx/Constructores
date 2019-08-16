using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }


        public Contacto()
        {
            Nombre = "Sin nombre";
            Celular = "Sin celular";
            Correo = "Sin correo";
            Telefono = " Sin telefono";
            Direccion = "Sin Direccion";

        }

        public Contacto(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
            Celular = "Sin celular";
            Telefono = "Sin Telefono";
            Direccion = "Sin Direccion";
        }

        public Contacto(string nombre, string celular, string telefono, string correo)
        {

        }
    }
}
