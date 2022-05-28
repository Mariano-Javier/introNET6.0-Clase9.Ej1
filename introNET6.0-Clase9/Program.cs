Console.WriteLine("Ingrese la longitud del vector");
int largoVector = int.Parse(Console.ReadLine());
int[] vector = new int[largoVector];
Random aleatorio = new Random();

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = aleatorio.Next(1, 100);
}
Console.WriteLine("");
Console.WriteLine("El vector es: ");
foreach (var item in vector)
{
    Console.WriteLine(item);
}

for (int i = 0; i < vector.Length/2; i++)
{
    int aux;
    aux = vector[i];
    vector[i] = vector[vector.Length-(i+1)];
    vector[vector.Length - (i + 1)] = aux;
}
Console.WriteLine("");
Console.WriteLine("El vector invertido es: ");
foreach (var item in vector)
{
    Console.WriteLine(item);
}
