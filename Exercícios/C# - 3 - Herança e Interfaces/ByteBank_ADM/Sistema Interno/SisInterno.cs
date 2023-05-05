using ByteBank_ADM.Funcionários;
using ByteBank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Sistema_Interno
{ 
    public class SisInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha, string login)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha,login);
            if(usuarioAutenticado) 
            {
                Console.WriteLine("Boas Vindas ao nosso sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha ou Login incorretos.");
                return false;
            }
        }
    }
}

