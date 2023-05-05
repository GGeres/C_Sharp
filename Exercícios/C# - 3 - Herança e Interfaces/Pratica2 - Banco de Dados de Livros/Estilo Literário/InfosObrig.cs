using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica2___Banco_de_Dados_de_Livros.Informações_Necessarias
{
    public abstract class InfosObrig
    {
        public string ISBN { get; private set; }
        public string Titulo { get; set; }
        public static int TotLivros { get; private set; }

        public InfosObrig(string isbn)
        {
            this.ISBN = isbn;
            TotLivros++;
        }
    }
}
