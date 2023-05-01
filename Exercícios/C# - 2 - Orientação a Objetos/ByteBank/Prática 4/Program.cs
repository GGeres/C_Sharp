using Prática_4;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaCorrente Gustavo = new ContaCorrente();
        Gustavo.numAgencia = 25;
        Gustavo.NumConta = "9190-X";



        Cliente GGeres = new Cliente();
        GGeres.nome = "Gustavo Geres";
        GGeres.cpf = "400.922.689-52";
        GGeres.prof = "Desenvolvedor";

        Console.WriteLine(Gustavo.numAgencia);
        Console.WriteLine(Gustavo.NumConta);
        Console.WriteLine(Gustavo.GetSaldo());
        Console.WriteLine(GGeres.nome);
        Console.WriteLine(GGeres.cpf);
        Console.WriteLine(GGeres.prof);
    }
}