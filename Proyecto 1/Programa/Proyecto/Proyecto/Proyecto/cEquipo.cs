using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto;

namespace Proyecto
{
    internal class cEquipo
    {
        string[] _Equipos = new string[9];
        double[] _PG = new double[9];
        double[] _PP = new double[9];
        double[] _PE = new double[9];
        double[] _PDE1 = new double[9];
        public void TxtEquipo()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.Write("Ingrese el nombre del equipo No." + i + ": ");
                _Equipos[i] = Console.ReadLine();
                Console.Write("Ingrese sus partidos ganados hasta el momento: ");
                _PG[i] = double.Parse(Console.ReadLine());
                Console.Write("Ingrese sus partidos perdidos hasta el momento: ");
                _PP[i] = double.Parse(Console.ReadLine());
                Console.Write("Ingrese sus partidos empatados hasta el momento: ");
                _PE[i] = double.Parse(Console.ReadLine());
                if (_PG[i] + _PP[i] + _PE[i] < 5 && _PG[i] + _PP[i] + _PE[i] > 3)
                {
                    Console.WriteLine("====================");
                }
                else
                {
                    Console.WriteLine("No cumple las reglas");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Presione ENTER para asignar los partidos con los equipos ingresados");
            Console.ReadKey();
        }
        public void Asignado1()
        {
            Console.Clear();
            Console.WriteLine("=====================================================================");
            Console.WriteLine("Los equipos han sido asignados y están listos para comenzar el Torneo");
            Console.WriteLine("Las asignaciones de equipos son las siguientes:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("El primer partido séra " + _Equipos[1] + " Contra " + _Equipos[2]);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("El segundo partido séra " + _Equipos[3] + " Contra " + _Equipos[4]);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("El tercer partido séra " + _Equipos[5] + " Contra " + _Equipos[6]);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("El cuarto partido séra " + _Equipos[7] + " Contra " + _Equipos[8]);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Presione ENTER para empezar los 4tos de Final");
            Console.WriteLine("=====================================================================");
            Console.ReadKey();
            Console.Clear();
        }
        public void calcularPoderDelEquipo()
        {
            for (int i1 = 1; i1 < 9; i1++)
            {
                _PDE1[i1] = ((_PG[i1] * 0.7) - (_PP[i1]*0.2) + (_PE[i1]*0.1))/4;
            }
        }
        public void P1()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("El 1er. partido a terminado, este es el resultado:");
            if (_PDE1[1] > _PDE1[2])
            {
                Console.WriteLine("El ganador del primer partido es " + _Equipos[1]);
            }
            else
            {
                Console.WriteLine("El ganador del primer partido es " + _Equipos[2]);
            }
            Console.WriteLine("==================================================");
            Console.ReadKey();
        }
        public void P2()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("El 2do. partido a terminado, este es el resultado:");
            if (_PDE1[3] > _PDE1[4])
            {
                Console.WriteLine("El ganador del segundo partido es " + _Equipos[3]);
            }
            else
            {
                Console.WriteLine("El ganador del segundo partido es " + _Equipos[4]);
            }
            Console.WriteLine("==================================================");
            Console.ReadKey();
        }
        public void P3()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("El 3er. partido a terminado, este es el resultado:");
            if (_PDE1[5] > _PDE1[6])
            {
                Console.WriteLine("El ganador del tercer partido es " + _Equipos[5]);
            }
            else
            {
                Console.WriteLine("El ganador del tercer partido es " + _Equipos[6]);
            }
            Console.WriteLine("==================================================");
            Console.ReadKey();
        }
        public void P4()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("El 4to. partido a terminado, este es el resultado:");
            if (_PDE1[7] > _PDE1[8])
            {
                Console.WriteLine("El ganador del segundo partido es " + _Equipos[7]);
            }
            else
            {
                Console.WriteLine("El ganador del segundo partido es " + _Equipos[8]);
            }
            Console.WriteLine("==================================================");
            Console.ReadKey();
            Console.Clear();
        }
        public void Asignado2()
        {
            Console.WriteLine("=====================================================================");
            Console.WriteLine("Los equipos han sido asignados y están listos para comenzar las Semifinales");
            Console.WriteLine("Las asignaciones de equipos son las siguientes:");
            Console.WriteLine("---------------------------------------");
            if (_PDE1[1] > _PDE1[2] && _PDE1[3] > _PDE1[4])
            {
                Console.WriteLine("El quinto partido séra " + _Equipos[1] + " Contra " + _Equipos[3]);
                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("El quinto partido séra " + _Equipos[2] + " Contra " + _Equipos[4]);
                Console.WriteLine("---------------------------------------");
            }
            if (_PDE1[5] > _PDE1[6] && _PDE1[7] > _PDE1[8])
            {
                Console.WriteLine("El sexto partido séra " + _Equipos[5] + " Contra " + _Equipos[6]);
                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("El sexto partido séra " + _Equipos[7] + " Contra " + _Equipos[8]);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("Presione ENTER para empezar las Semifinales");
            Console.WriteLine("=====================================================================");
            Console.ReadKey();
            Console.Clear();
        }
        public void P5()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("El 5to. partido a terminado, este es el resultado:");
            if (_PDE1[7] > _PDE1[8])
            {
                Console.WriteLine("El ganador del quinto partido es " + _Equipos[1]);
            }
            else
            {
                Console.WriteLine("El ganador del quinto partido es " + _Equipos[3]);
            }
            Console.WriteLine("==================================================");
            Console.ReadKey();
            Console.Clear();
        }
        public void P6()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("El 6to. partido a terminado, este es el resultado:");
            if (_PDE1[5] > _PDE1[6])
            {
                Console.WriteLine("El ganador del sexto partido es " + _Equipos[5]);
            }
            else
            {
                Console.WriteLine("El ganador del sexto partido es " + _Equipos[7]);
            }
            Console.WriteLine("==================================================");
            Console.ReadKey();
            Console.Clear();
        }
        public void Asignado3()
        {
            Console.WriteLine("=====================================================================");
            Console.WriteLine("Los equipos han sido asignados y están listos para comenzar las Finales");
            Console.WriteLine("Las asignaciones de equipos son las siguientes:");
            Console.WriteLine("---------------------------------------");
            if (_PDE1[1] > _PDE1[4] && _PDE1[5] > _PDE1[8])
            {
                Console.WriteLine("El quinto partido séra " + _Equipos[1] + " Contra " + _Equipos[4]);
                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("El quinto partido séra " + _Equipos[5] + " Contra " + _Equipos[8]);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("Presione ENTER para empezar las Finales");
            Console.WriteLine("=====================================================================");
            Console.ReadKey();
            Console.Clear();
        }
        public void P7()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("El 7mo. partido a terminado, este es el resultado:");
            if (_PDE1[1] > _PDE1[8])
            {
                Console.WriteLine("El ganador del septimo partido es " + _Equipos[1]);
            }
            else
            {
                Console.WriteLine("El ganador del septimo partido es " + _Equipos[8]);
            }
            Console.WriteLine("==================================================");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
