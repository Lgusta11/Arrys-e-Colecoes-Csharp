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
    }
}
