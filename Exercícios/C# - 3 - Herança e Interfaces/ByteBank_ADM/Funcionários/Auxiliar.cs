using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionários
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf,2000) 
        { 
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.2;
        }

        public override void AumentarSal()
        {
            this.Salario *= 1.1;
        }
    }
}
