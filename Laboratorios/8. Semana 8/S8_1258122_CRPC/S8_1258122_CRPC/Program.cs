Console.WriteLine("==========Ejercicio laboratorio 8==========");
Console.WriteLine("===========Convertidor a Binario===========");

int x, y = 0;
string suma = "";

Console.Write("Ingrese un número: ");
x = int.Parse(Console.ReadLine());

while (x > 0)
{
    y = x % 2;
    if (y == 0)
    {
        suma = "0" + suma;
    }
    else
    {
        suma = "1" + suma;
    }
    x = x / 2;
}

Console.WriteLine("la conversion del numero ingresado: " + suma.ToString());
