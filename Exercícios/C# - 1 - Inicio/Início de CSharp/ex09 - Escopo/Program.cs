using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Escopo");
        int idadeJohn = 19;
        int qtdPessoas = 1;

        
        bool grupo = qtdPessoas >=2;

        string textoAd;
        
        if(grupo == true)
        {
            textoAd = "Você está acompanhado.";
        }
        else
        {
            textoAd = "Você não está acompanhado.";
        }

        if (idadeJohn >=18 || grupo)
        {
            Console.WriteLine("Pode entrar! " +textoAd);
        }
        else
        {
            Console.WriteLine("Não pode entrar. " +textoAd);
        }
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}

