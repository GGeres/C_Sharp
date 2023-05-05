using ByteBank_ADM.Sistema_Interno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionários
{
    public abstract class FuncAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }
        public string Login { get; set; }

        public bool Autenticar(string senha, string login)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}
