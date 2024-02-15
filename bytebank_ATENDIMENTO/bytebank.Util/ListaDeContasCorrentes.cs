using System;
using System.Collections.Generic;

namespace bytebank.Modelos.Conta
{
    public class ListaDeContasCorrentes
    {
        public List<ContaCorrente> Contas { get; } = new List<ContaCorrente>();

        private ContaCorrente[] _itens;
        private int _proximaPosicao = 0;

        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        public void Adicionar(ContaCorrente conta)
        {
            Console.WriteLine($"Adicionando conta na posição {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = conta;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens == null)
            {
                _itens = new ContaCorrente[tamanhoNecessario];
                return;
            }

            if (_itens.Length >= tamanhoNecessario) return;

            Console.WriteLine("Aumentando capacidade da lista");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }

            _itens = novoArray;
        }

        public void Remover(ContaCorrente conta)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ListaDeContasCorrentes contaAtual = _itens[i];
                if (notaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null; -



        }

        public void exibeLista()
        {
            if (_itens[1] != null)
            {
                var conta = _itens[1];
                Console.WriteLine($"indice[{i}] = Conta: {conta.Conta} - Numero da Agencia: {conta.Numero_Agencia}");
            }
        }

    }
}
