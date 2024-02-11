Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

TestaArray();

void TestaArray()
{
    int[] idades = { 10, 5, 15, 8, 6 }; // inicialização direta do array

    Console.WriteLine($"Tamanho do array: {idades.Length}");

    Console.WriteLine("Idades:");

    for (int i = 0; i < idades.Length; i++)
    {
        Console.WriteLine($"Índice [{i}] = {idades[i]}");
    }

    int soma = 0;
    foreach (int idade in idades)
    {
        soma += idade;
    }

    double media = (double)soma / idades.Length;

    Console.WriteLine($"\nA média das idades é: {media:F2}\n");
}
