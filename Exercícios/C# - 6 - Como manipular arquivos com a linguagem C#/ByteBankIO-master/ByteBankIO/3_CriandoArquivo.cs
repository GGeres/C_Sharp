using System.Text;
using ByteBankIO;

partial class Program
{

    static void CriarArquivo()
    {
        var arqString = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream (arqString, FileMode.Create))
        {
            var vstring = "55, 741-00, 5800.50, Gustavo Gayer.";
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes (vstring);
            fluxoDeArquivo.Write (bytes, 0, bytes.Length);
        }
    }

    static void CriarWriter()
    {
        var arqString = "contasExportadas.csv";
        using(var fluxoDeArquivo = new FileStream(arqString, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("77, 856-00, 7500.08, Pedro Rodrigues.");
        }
    }

    static void TestaEscrita()
    {
        var camArquivo = "teste.txt";
        using (var fluxoDeArquivo = new FileStream(camArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 100000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush();
                Console.WriteLine($"A linha {i} foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                Console.ReadLine();
            }
        }

    }


    static void EscritaBinaria()
    {

        using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
        using (var escritor = new BinaryWriter(fs))
        {
            escritor.Write(456);       // Número da Agência
            escritor.Write(546544);   // Número da conta
            escritor.Write(4000.50); // Saldo
            escritor.Write("Gustavo Braga");
        }
    }

    static void LeituraBinaria()
    {
        using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
        using (var leitor = new BinaryReader(fs))
        {
            var agencia = leitor.ReadInt32();
            var numConta = leitor.ReadInt32();
            var saldo = leitor.ReadDouble();
            var titular = leitor.ReadString();

            Console.WriteLine($"{agencia}/{numConta} {titular} {saldo}");
        }
    }
}

