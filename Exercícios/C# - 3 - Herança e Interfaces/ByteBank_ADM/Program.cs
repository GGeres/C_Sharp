using ByteBank_ADM.Funcionários;
using ByteBank_ADM.Parceria;
using ByteBank_ADM.Sistema_Interno;
using ByteBank_ADM.Utilitario;


#region
//Funcionario Pedro = new Funcionario("859.621.745-22", 2000);
//Pedro.Nome = "Pedro Correia";

//Console.WriteLine(Pedro.Nome);
//Console.WriteLine(Pedro.GetBonificacao());

//Diretor Claudia = new Diretor("564.839.778-32");
//Claudia.Nome = "Claudia Gomez";

//Console.WriteLine(Claudia.Nome);
//Console.WriteLine(Claudia.GetBonificacao());

//Gerenciador_de_Bonificacao gerenciador = new Gerenciador_de_Bonificacao();
//gerenciador.Registrar(Pedro);
//gerenciador.Registrar(Claudia);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBoni);



//Console.WriteLine("Total de funcionários: "+Funcionario.TotalDeFunc);

//Pedro.AumentarSal();
//Claudia.AumentarSal();

//Console.WriteLine("Novo salário do Pedro: "+ Pedro.Salario);
//Console.WriteLine("Novo salário da Claudia: "+ Claudia.Salario);
#endregion
//CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    Gerenciador_de_Bonificacao gerenciador = new Gerenciador_de_Bonificacao();

    Designer Ulisses = new Designer("556.884.921-25");
    Ulisses.Nome = "Ulisses Costa";

    Diretor Paulo = new Diretor("928.446.853-69");
    Paulo.Nome = "Paulo Longo";

    GerenteDeContas Yngrid = new GerenteDeContas("770.618.741-X");
    Yngrid.Nome = "Yngrid Morais";

    Auxiliar Moises = new Auxiliar("198.663.745-38");
    Moises.Nome = "Moisés da Silva";

    gerenciador.Registrar(Moises);
    gerenciador.Registrar(Yngrid);
    gerenciador.Registrar(Paulo);
    gerenciador.Registrar(Ulisses);

    Console.WriteLine("Total de bonificação = " + gerenciador.TotalDeBoni);


}

void UsarSistema()
{
    SisInterno sistema = new SisInterno();

    Diretor Saul = new Diretor("771.552.331-55");
    Saul.Nome = "Saul Oliveira";
    Saul.Senha = "443";
    Saul.Login = "Sau01";

    GerenteDeContas Alfredo = new GerenteDeContas("854.431.345-11");
    Alfredo.Nome = "Alfredo Martins";
    Alfredo.Senha = "454";
    Alfredo.Login = "Alf01";

    ParComercial caio = new ParComercial();
    caio.Senha = "999";
    caio.Login = "Caio01";

    sistema.Logar(Saul, "443", "Sau01");
    sistema.Logar(Alfredo, "455", "Alf01");
    sistema.Logar(caio, "999", "Caio01");

}