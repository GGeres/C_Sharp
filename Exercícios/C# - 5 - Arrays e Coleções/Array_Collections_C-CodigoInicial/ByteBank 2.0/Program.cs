using bytebank.Modelos.Conta;
using ByteBank_2._0.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-D"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-E"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-F"));
    var contaDoAndre = new ContaCorrente(966, "1234567-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("=============");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for(int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
    }




}

TestaArrayDeContasCorrentes();