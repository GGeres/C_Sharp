using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

namespace bytebank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoUtil autenticacao = new AutenticacaoUtil();
        public string Senha { get; set; }
      
        public bool Autenticar(string senha)
        {
            return autenticacao.Autentificar(this.Senha, senha);
        }
    }
}
