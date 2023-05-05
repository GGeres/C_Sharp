using ByteBank_ADM.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Utilitario
{
    internal class Gerenciador_de_Bonificacao
    {
        public double TotalDeBoni { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBoni += funcionario.GetBonificacao();
        }
    }
}
