using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuerta
{
    class Puerta
    {
        int alto;
        int ancho;
        ConsoleColor color;
        bool abierta = false; //** Yo he controlado el estado así pero, si quieres puedes hacerlo de otro modo 

		#region Propiedades


		#endregion

		//---- Constructores -----

		//---- Métodos ----
		public void Abrir()
        {

        }

        public void Cerrar()
        {

        }

        public void Mostrar() 
        {
            // aquí falta una línea
			Console.WriteLine("\n\n\tEstado: {0}" );
			Console.WriteLine("\n\tAlto: {0}" );
			Console.WriteLine("\tAncho: {0}" );
            
            Console.Write("\tColor: ████████ ");
			// aquí falta una línea
			Console.WriteLine("◄ Este color");
		}
    }
}
