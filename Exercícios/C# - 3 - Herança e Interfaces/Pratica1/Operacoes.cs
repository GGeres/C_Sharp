using Pratica1.Operações_Básicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica1
{
    internal class Operacoes
    {
        public Soma Soma { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Multi Multi { get; private set; }
        public Divisao Divisao { get; private set; }

        public Operacoes()
        {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Multi = new Multi();
            this.Divisao = new Divisao();
        }
    }
}
