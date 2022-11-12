using T12_1258122_CRPC;
int cantidadEquipos = 8;
Equipo[] equipos = new Equipo[cantidadEquipos];
Random random = new Random();
int seleccionarGanador(int i, int j)
{
    int x = random.Next(0, 100);
    if (x > 50)
    {
        return j;
    }
    return i;
}
void mostrarEquipos()
{
    int i = 0;
    int j = cantidadEquipos - 1;
    while (i < cantidadEquipos / 2)
    {
        Console.WriteLine(equipos[i].nombre + " vs " + equipos[j].nombre);
        i++;
        j--;
    }
    Console.WriteLine("");
    Console.WriteLine("===========================");
    Console.WriteLine("");
}
void SortearEquipos()
{
    for (int i = 0; i < cantidadEquipos; i++)
    {
        int x = random.Next(0, cantidadEquipos);
        Equipo aux = equipos[i];
        equipos[i] = equipos[x];
        equipos[x] = aux;
    }
}
void simulacion()
{
    while (cantidadEquipos > 1)
    {
        int i = 0;
        int j = cantidadEquipos - 1;
        mostrarEquipos();
        while (i < cantidadEquipos / 2)
        {
            Console.WriteLine(equipos[i].nombre + " vs " + equipos[j].nombre);
            int x = seleccionarGanador((int)i, (int)j);
            Equipo aux = equipos[i];
            equipos[i] = equipos[x];
            equipos[x] = aux;
            Console.WriteLine("Gano: " + equipos[i].nombre);
            i++;
            j--;
            Console.WriteLine("");
            Console.WriteLine("--------------------");
            Console.WriteLine("");
        }
        cantidadEquipos = cantidadEquipos / 2;
    }
    Console.WriteLine("El ganador del Torneo es: " + equipos[0].nombre);
}
for (int i = 0; i < equipos.Length; i++)
{
    equipos[i] = new Equipo();
    equipos[i].nombre = "Equipo " + i;
}
SortearEquipos();
simulacion();