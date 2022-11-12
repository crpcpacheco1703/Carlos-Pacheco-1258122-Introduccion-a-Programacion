using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    internal class cInicio
    {
        public void TxtInicio()
        {
            //Creación de la introducción del Programa
            Console.WriteLine("==========Bienvenido al Simulador del Torneo de Fútbol==========");
            Console.ReadKey();
            Console.WriteLine("Instrucciones:");
            Console.WriteLine("==============================");
            Console.WriteLine("A continuación se le mostrara un espacio donde colocar el nombre de los equipos deseados");
            Console.WriteLine("Tambien le pediran su PG (Ganados), PP (Perdidos), PE (Empatados) hasta el momento");
            Console.WriteLine("La sumatoria inicial de PG, PP Y PE debe de ser igual a 4, de otra forma se terminara el programa");
            Console.WriteLine("Una vez colocado los datos, el programa comenzará a reproducir un torneo");
            Console.WriteLine("Por lo que usted podrá ver como cada uno se enfrenta entre si de forma aleatoria");
            Console.WriteLine("EL programa se detendra cada que termine un partido, por lo que tendra que presionar ENTER para continuar");
            Console.WriteLine("Presione ENTER si comprendio las instrucciones y desea empezar el programa");
            Console.WriteLine("==============================");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("=======================================================");
            Console.WriteLine("Coloque el nombre que desea de sus 8 Equipos de Fútbol:");
        }
    }
}
