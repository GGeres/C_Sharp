using Pratica2___Banco_de_Dados_de_Livros.Informações_Necessarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica2___Banco_de_Dados_de_Livros.Estilo_Literário
{
    public class Aventura : InfosObrig
    {
        public Aventura(string isbn) : base(isbn)
        {
        }

        public string Autor { get; set; }
        public string Estilo { get; set; }
        public int numPag { get; set; }
        public int anoPubli { get; set; }
        public string paisPubli { get; set; }
    }
}
