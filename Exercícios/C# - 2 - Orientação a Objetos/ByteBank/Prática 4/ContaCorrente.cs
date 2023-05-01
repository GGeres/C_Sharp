using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prática_4
{
    internal class ContaCorrente
    {
        public int numAgencia;
        private string numConta;
        public string NumConta { get; set; }

        private double saldo = 200;

        public Cliente Titular { get; set; }


        public void SetSaldo (double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
