using ByteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public int numAgencia;
        public string conta;
        public double saldo = 100;

        public Cliente titular;
        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void Exibir()
        {
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Número da agência: " + numAgencia);
            Console.WriteLine("Número da conta: " + conta);
            Console.WriteLine("Saldo disponível: " + saldo);
        }
    }
}
