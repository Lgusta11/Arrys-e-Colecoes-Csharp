using System;
using bytebank.Modelos.Conta;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos Arrays
class Program
{
    static void Main()
    {


        Array amostra = Array.CreateInstance(typeof(double), 5);
        amostra.SetValue(34, 0);
        amostra.SetValue(78, 1);
        amostra.SetValue(29, 2);
        amostra.SetValue(67, 3);
        amostra.SetValue(45, 4);

        //TestaArrayContas();
    }

    static void TestaArrayContas()
    {
        ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
        listaDeContas.Adicionar(new ContaCorrente(123456, "555325-A"));
        listaDeContas.Adicionar(new ContaCorrente(221212, "879325-B"));
        listaDeContas.Adicionar(new ContaCorrente(123456, "879333-C"));
        var contaGusta = new ContaCorrente(765, "123445-D");
        listaDeContas.Adicionar(contaGusta);
        // listaDeContas.exibeLista();
        // Console.WriteLine("================================================================");
        // listaDeContas.Remover(contaGusta);
        // listaDeContas.exibeLista();

        for (int i = 0; i < listaDeContas.Tamanho; i++)
        {
            ContaCorrente conta = listaDeContas[1];
            Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
        }



    }
}

#endregion

ArrayList _listaDeContas = new ArrayList();

public void AtendimentoCliente()
{
    char opcao = "0";
    while (opcao != '6') ;
    while (true)
    {
        Console.Clear();
        Console.WriteLine($"ATENDIMENTO \n");
        Console.WriteLine($"1 - Cadastrar Conta");
        Console.WriteLine($"2 - Listar Conta");
        Console.WriteLine($"3 - Excluir Conta");
        Console.WriteLine($"4 - Ordenar Conta");
        Console.WriteLine($"5 - Pesquisa Conta");
        Console.WriteLine($"6 - Sair \n\n");
         Console.Write($"Selecione uma Opção");
        opcao =  Console.ReadLine() [0];
        switch (opcao)
        {
            case '1':
                CadastrarConta();
                break;
                default: Console.WriteLine($"Opcao nao implementada");
                break;
            
        }

        void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine($"Cadastro de Conta");
            Console.WriteLine($"\n");
            Console.WriteLine($"Informe os dados da sua Conta");
            Console.Write(Numero de conta: );
            string numeroConta = Console.ReadLine();

            Console.Write($"Numero da Agencia");
            int numeroAgencia = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

            
            
            
            
        }
        
        



    }
}


//cd "C:\Users\Admin\Desktop\Array_Collections_C-CodigoInicial\bytebank_ATENDIMENTO"