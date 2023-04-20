using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPuerta
{
    class Util
    {
		// Faltan bastantes cláusulas

		int CapturaEntero(string mensaje, int min, int max)
        {
            int valor = 0;

			// rellena aquí

            return valor;
        }

        int CapturaNumPulsado(string mensaje, int min, int max)
        {
            int valor = 0;

			// rellena aquí

			return valor;
        }

        int Menu()
        {
            Console.Clear();
			Console.WriteLine("\n\n\n\n");
			Console.WriteLine("\t\t\t╔═════════════════════╗");
            Console.WriteLine("\t\t\t║   MENÚ de PUERTA    ║");
            Console.WriteLine("\t\t\t╠═════════════════════╣");
            Console.WriteLine("\t\t\t║     1) Abrir        ║");
            Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     2) Cerrar       ║");
			Console.WriteLine("\t\t\t║                     ║");
			Console.WriteLine("\t\t\t║     3) Mostrar      ║");
			Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     4) Pintar       ║");
			Console.WriteLine("\t\t\t║                     ║");
			Console.WriteLine("\t\t\t║     5) Fabricar     ║");
			Console.WriteLine("\t\t\t║_____________________║");
            Console.WriteLine("\t\t\t║                     ║");
            Console.WriteLine("\t\t\t║     0) Salir        ║");
            Console.WriteLine("\t\t\t╚═════════════════════╝");

            return CapturaNumPulsado("\t\t\tPulse su opción", 0, 5);
        }

		//ConsoleColor EligeColor()
		//{
		//	Console.WriteLine("\n\tElige un color");



		//	int indice = CapturaNumPulsado("\t¿Color?", 0, ¿?);

		//	return ¿?;
		//}

	}
}
