Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

TestaBuscarPalavra();


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
void TestaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.WriteLine($"Digite a {i + 1}ª palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("\nQual palavra você deseja buscar? ");
    var busca = Console.ReadLine();

    bool palavraEncontrada = false;

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            palavraEncontrada = true;
            break;
        }
    }

    if (palavraEncontrada)
    {
        Console.WriteLine($"Palavra '{busca}' encontrada.");
    }
    else
    {
        Console.WriteLine($"Palavra '{busca}' não encontrada.");
    }
}


