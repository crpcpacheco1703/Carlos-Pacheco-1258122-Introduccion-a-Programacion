using Proyecto_2;

Album album = new Album();
Inicio inicio = new Inicio();

inicio.TxtInicio();
inicio.TxtMenu();
Txtmodificar();
salida();
void Txtmodificar()
{
    Console.Clear();
    Console.WriteLine("============Modificar Estado de estampas=============");
    Console.WriteLine("=====================================================");
    Console.WriteLine("Aqui podra modificar el estado de sus estampas");
    Console.WriteLine("Ejemplo del codigo de una estampa: QAT7");
    Console.Write("Escriba el codigo de estampa que quiera modificar: ");
    string codigo = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("============Modificar Estado de estampas=============");
    Console.WriteLine("==========================================");
    Console.WriteLine("Escoga el estado que desea para la Estampa");
    Console.WriteLine("1. Faltante");
    Console.WriteLine("2. Obtenida");
    Console.WriteLine("3. Repetida");
    Console.WriteLine("4. Cancelar");
    Console.Write("Escriba el numero: ");
    string opcion = Console.ReadLine();
    if (opcion == "2")
    {
        int i = album.buscarEstampa(codigo);

    if (i >= 0)
    {
        album.estampas[i].marcar();
    }
    else
    {
        Console.WriteLine("Estampa no encontrada");
    }
        Console.WriteLine("======================================");
        Console.WriteLine("Listo");
        Console.WriteLine("Presione ENTER para regresar");
        Console.ReadKey();
        Console.Clear();
        inicio.TxtMenu();
    }

    if (opcion == "1")
    {
        int i = album.buscarEstampa(codigo);

        if (i >= 0)
        {
            album.estampas[i].faltar();
        }
        else
        {
            Console.WriteLine("Estampa no encontrada");
        }
        Console.WriteLine("======================================");
        Console.WriteLine("Listo");
        Console.WriteLine("Presione ENTER para regresar");
        Console.ReadKey();
        Console.Clear();
        inicio.TxtMenu();
    }

    if (opcion == "3")
    {
        int i = album.buscarEstampa(codigo);

        if (i >= 0)
        {
            album.estampas[i].repetir();
        }
        else
        {
            Console.WriteLine("Estampa no encontrada");
        }
        Console.WriteLine("======================================");
        Console.WriteLine("Listo");
        Console.WriteLine("Presione ENTER para regresar");
        Console.ReadKey();
        Console.Clear();
        inicio.TxtMenu();
    }

    if (opcion == "4")
    {
        Console.Clear();
        inicio.TxtMenu();
    }
}

void salida()
{
    Console.Clear();
}