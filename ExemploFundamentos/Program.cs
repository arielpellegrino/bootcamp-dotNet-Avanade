

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;


//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

int[] arrayInteiroDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteiroDobrado, arrayInteiros.Length);

for(int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine(arrayInteiros[i]);
}

// int contadorForEach = 0;
// foreach(int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição Nº {contadorForEach} - {valor}");
//     contadorForEach++;
// }