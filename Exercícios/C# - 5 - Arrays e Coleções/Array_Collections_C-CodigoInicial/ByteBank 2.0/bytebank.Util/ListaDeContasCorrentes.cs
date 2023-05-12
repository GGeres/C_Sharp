using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_2._0.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proxPosicao = 0;

        public ListaDeContasCorrentes(int tamanhoInicial=5)
        {
            _itens = new ContaCorrente[tamanhoInicial]; 
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proxPosicao}");
            VeriCapacidade(_proxPosicao + 1);
            _itens[_proxPosicao] = item;
            _proxPosicao++;
        }

        private void VeriCapacidade(int tamNecessario)
        {
            if(_itens.Length>= tamNecessario )
            {
                return;
            }
            Console.WriteLine("Aumentando a capacidade da Lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i]= _itens[i];
            }

            _itens = novoArray;
        }

        public void Remover (ContaCorrente conta)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proxPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if (contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }

            for(int i = indiceItem; i < _proxPosicao-1; i++)
            {
                _itens[i] = _itens[i+1];
            }
            _proxPosicao--;
            _itens[_proxPosicao] = null;
        }
        
        public void ExibeLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if (_itens[i] != null)
                {
                    var conta = _itens[i];
                    Console.WriteLine($" Indice[{i}] = " +
                        $"Conta:{conta.Conta} - " +
                        $"N° da Agência: {conta.Numero_agencia}");
                }
            }
        }

        public ContaCorrente RecuperarContaNoIndice (int indice)
        {
            if (indice < 0 || indice >= _proxPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
        }

        internal ContaCorrente RecuperarItemIndice(int i)
        {
            throw new NotImplementedException();
        }

        public int Tamanho { get
            {
                return _proxPosicao;
            }
        }

        public ContaCorrente this[int indice]
        {
            get
            {
                return RecuperarContaNoIndice(indice);
            }
        }

    }
}
