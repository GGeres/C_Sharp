using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_Modelos.bytebank.Modelos.ADM.Utilitario
{
    public class AutenticacaoUtil
    {
        public bool Autentificar(string senhaV, string senhaT)
        {
            return senhaT.Equals(senhaT);
        }
    }
}
