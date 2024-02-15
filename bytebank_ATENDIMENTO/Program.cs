using System;
using bytebank.Modelos.Conta;

class Program
{
    static void Main()
    {
        Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

        Array amostra = Array.CreateInstance(typeof(double), 5);
        amostra.SetValue(34, 0);
        amostra.SetValue(78, 1);
        amostra.SetValue(29, 2);
        amostra.SetValue(67, 3);
        amostra.SetValue(45, 4);

        TestaArrayContas();
    }

    static void TestaArrayContas()
    {
        ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
        listaDeContas.Adicionar(new ContaCorrente(123456, "555325-A"));
        listaDeContas.Adicionar(new ContaCorrente(221212, "879325-B"));
        listaDeContas.Adicionar(new ContaCorrente(123456, "879333-C"));
        var contaGusta = new ContaCorrente(765 , "123445-D");
        listaDeContas.Adicionar(contaGusta);
        listaDeContas.exibeLista();
        Console.WriteLine("================================================================");
        listaDeContas.Remover(contaGusta);
        listaDeContas.exibeLista();

       
    }
}
