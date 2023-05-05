using ByteBank_ADM.Sistema_Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionários
{
    public class Diretor : FuncAutenticavel
    {
        
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public Diretor(string cpf) : base(cpf,5000)
        {
            //Console.WriteLine("Criando um diretor.");
        }

        public override void AumentarSal()
        {
            this.Salario *= 1.15;
        }
    }
}
