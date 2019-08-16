using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1
                = new Contacto();
            contacto1.Nombre = "Jose";
            contacto1.Celular = "(642) 2 415 222";
            contacto1.Correo = "jose@correo.com";


            Console.WriteLine("Nombre:" + contacto1.Nombre);
            Console.WriteLine("Correo:" + contacto1.Celular);
            Console.WriteLine("Direccion:" + contacto1.Direccion);
            Console.WriteLine("Correo:" + contacto1.Correo);

            Contacto contacto2 =
                new Contacto("Pepe", "Pepe@correo.com");
            Console.WriteLine("Contacto 2:");
            Console.WriteLine("Nmobre:" + contacto2.Nombre);
            Console.WriteLine("Correo:" + contacto2.Correo);
            Console.WriteLine("Direccion:" + contacto2.Direccion);

            Console.Read();
        }
    }
}
