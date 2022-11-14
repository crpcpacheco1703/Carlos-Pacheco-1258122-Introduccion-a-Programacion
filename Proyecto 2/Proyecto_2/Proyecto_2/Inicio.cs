using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    internal class Inicio
    {
        public Estampa[] estampas;
        Album album = new Album();
        Program program = new Program();
        
        public void TxtInicio()
        {
            Console.WriteLine("==========Bienvenido al Album Panini Virtual==========");
            Console.ReadKey();
            Console.WriteLine("Instrucciones: ");
            Console.WriteLine("====================================");
            Console.WriteLine("A continuación se le mostrará el menu principal del album");
            Console.WriteLine("Usted podra ver, tanto cuales estampas tiene, le falta o tiene repetidas");
            Console.WriteLine("Además podra modificar el estado de cada estampa que quiera con estos 3 estados");
            Console.WriteLine("Presione ENTER para continuar");
            Console.WriteLine("====================================");
            Console.ReadKey();
            Console.Clear();
        }

        public void TxtMenu()
        {
            Console.WriteLine("==========Menu==========");
            Console.WriteLine("Escoga una de las opciones: ");
            Console.WriteLine("1. Mostrar Estado de las estampas");
            Console.WriteLine("2. Modificar Estado de las estampas");
            Console.WriteLine("3. Salir");
            Console.Write("Escriba el número: ");
            string opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Txtmostrar();
            }
            else if (opcion == "2")
            {
                Console.Clear();
            }
            else if (opcion == "3")
            {
                Txtsalida();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opcion Invalida");
                Console.ReadKey();
                Console.Clear();
                TxtMenu();
            }
        } 

        public void Txtsalida()
        {
            Console.Clear();
            Console.WriteLine("Adios :)");
        }

        public void Txtmostrar()
        {
            Console.Clear();
            Console.WriteLine("==============Mostrar Estado de estampas=============");
            Console.WriteLine("=====================================================");
            Console.WriteLine("Aqui podra ver el estado de sus estampas");
            Console.WriteLine("Que Estampas desea ver:");
            Console.WriteLine("1. Faltantes");
            Console.WriteLine("2. Obtenidas");
            Console.WriteLine("3. Repetidas");
            Console.WriteLine("4. Regresar");
            Console.Write("Escriba el numero: ");
            string opcion =Console.ReadLine();
            if (opcion == "1")
            {
                Console.Clear();
                album.mostrarFaltantes();
                Console.WriteLine("=====================================================");
                Console.WriteLine("Presione ENTER para regresar");
                Console.ReadKey();
                Console.Clear();
                Txtmostrar();
            }
            else if (opcion == "2")
            {
                Console.Clear();
                album.mostrarMarcadas();
                Console.WriteLine("=====================================================");
                Console.WriteLine("Presione ENTER para regresar");
                Console.ReadKey();
                Console.Clear();
                Txtmostrar();
            }
            else if (opcion == "3")
            {
                Console.Clear();
                album.mostrarRepetidas();
                Console.WriteLine("=====================================================");
                Console.WriteLine("Presione ENTER para regresar");
                Console.ReadKey();
                Console.Clear();
                Txtmostrar();
            }
            else if (opcion == "4")
            {
                Console.Clear();
                TxtMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opcion Invalida");
                Console.WriteLine("Presione ENTER para regresar");
                Console.ReadKey();
                Console.Clear();
                Txtmostrar();
            }
        }
    }
}
