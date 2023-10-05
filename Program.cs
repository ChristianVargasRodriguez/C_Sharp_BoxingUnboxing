// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<object> miLista = new List<object>();

miLista.Add(7);
miLista.Add(28);
miLista.Add(-1);
miLista.Add(true);
miLista.Add("chair");

Console.WriteLine("Valores en la lista:");
foreach (var item in miLista)
{
    Console.WriteLine(item);
}

int suma = 0;
foreach (var item in miLista)
{
    if (item is int) // Verificar si el elemento es de tipo int.
    {
        suma += (int)item; // Sumar el valor si es de tipo int.
    }
}
Console.WriteLine("Suma de los valores enteros: " + suma);