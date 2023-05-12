using bytebank.Modelos.Conta;
using ByteBank_2._0.bytebank.Util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


#region Exemplos Arrays em C#
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

//TestaArrayDeContasCorrentes();
#endregion Exe

ArrayList _listaDeContas = new ArrayList();

AtendimentoCliente();
void AtendimentoCliente()
{
    char opcao = '0';
    while(opcao!='6')
    {
        Console.Clear();
        Console.WriteLine("================================");
        Console.WriteLine("=====      Atendimento     =====");
        Console.WriteLine("=====1 - Cadastrar Conta   =====");
        Console.WriteLine("=====2 - Listar Contas     =====");
        Console.WriteLine("=====3 - Remover Contar    =====");
        Console.WriteLine("=====4 - Ordenar Contas    =====");
        Console.WriteLine("=====5 - Pesquisar Conta   =====");
        Console.WriteLine("=====6 - Sair do Sistema   =====");
        Console.WriteLine("================================");
        Console.WriteLine("\n\n");
        Console.Write("Digite a opção desejada: ");
        opcao = Console.ReadLine()[0];
        switch (opcao)
        {
            case '1': CadastrarConta();
                break;
            case '2': ListarContas();
                break;
            default:
                Console.WriteLine("Opção não implementada.");
                break;

        }
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("==============================");
    Console.WriteLine("====  CADASTRO DE CONTAS  ====");
    Console.WriteLine("==============================");
    Console.WriteLine("\n");
    Console.WriteLine("==  Informe dados da conta  ==");
    Console.Write("Número de conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Numero da Agência: ");
    int numeroAgencia = int.Parse (Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Informe o nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Informe o CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Informe profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);
    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("====    LISTA DE CONTAS    ====");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    if(_listaDeContas.Count <= 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }
    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===  Dados da Conta  ===");
        Console.WriteLine("Número da Conta: " + item.Conta);
        Console.WriteLine("Titular da Conta: " + item.Titular.Nome);
        Console.WriteLine("CPF do Titular: "+ item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: " + item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey ();
    }


}