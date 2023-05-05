using ByteBank_ADM.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Sistema_Interno
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }
        public string Login { get; set; }
        public bool Autenticar(string senha, string login);
    }
}
