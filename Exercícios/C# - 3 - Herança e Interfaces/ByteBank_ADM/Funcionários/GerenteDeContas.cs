using ByteBank_ADM.Sistema_Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionários
{
    public class GerenteDeContas :FuncAutenticavel
    {
       
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
        }
        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSal()
        {
            this.Salario *= 1.5;
        }
    }
}
