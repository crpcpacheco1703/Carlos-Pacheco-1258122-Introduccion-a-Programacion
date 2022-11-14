using S9_1258122_CRPC;

Circulo circulo = new Circulo();
Console.Write("Ingrese un radio: ");
circulo.radio = double.Parse(Console.ReadLine());

Console.WriteLine("Perimetro: " + circulo.ObtenerPerimetro());
Console.WriteLine("Area: " + circulo.ObtenerArea());
Console.WriteLine("Volumen: " + circulo.ObtenerVolumen());