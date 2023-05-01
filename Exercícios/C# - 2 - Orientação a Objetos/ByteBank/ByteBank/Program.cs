using ByteBank.Contas;
using ByteBank.Titular;

//ContaCorrente contaAndre = new ContaCorrente();
//contaAndre.titular = "André silva";
//contaAndre.numAgencia = 15;
//contaAndre.conta = "1010-x";
//contaAndre.saldo = 100;

//Console.WriteLine("saldo da conta do André = " + contaAndre.saldo);

//contaAndre.Exibir();

//ContaCorrente contaAndre2 = new ContaCorrente();
//contaAndre2.titular = "andré silva";
//contaAndre2.numAgencia = 15;
//contaAndre2.conta = "1010-x";
//contaAndre2.saldo = 100;

//Console.WriteLine("saldo da conta do André = " + contaAndre2.saldo);

//contaAndre = contaAndre2;

//Console.WriteLine(contaAndre == contaAndre2);

//contaAndre.Depositar(100);

//Console.WriteLine("Saldo da conta do André pós-depósito = " + contaAndre.saldo);

//if (contaAndre.Sacar(300) == true)
//{
//    Console.WriteLine("Saldo da conta do André " + contaAndre.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para saque");
//}

//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria Souza";
//contaMaria.numAgencia = 17;
//contaMaria.conta = "1010-5";
//contaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria = " + contaMaria.saldo);

//contaAndre.Transferir(50, contaMaria);
//Console.WriteLine("Saldo do André = "+ contaAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaMaria.saldo);

//ContaCorrente contaPedro = new ContaCorrente();
//contaPedro.titular = "Pedro Silva";
//Console.WriteLine(contaPedro.titular);
//Console.WriteLine(contaPedro.saldo);
//Console.WriteLine(contaPedro.numAgencia);
//Console.WriteLine(contaPedro.conta);


//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "890.552.741-25";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numAgencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Nº de conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("Nº da Agência = " + conta.numAgencia);

ContaCorrente conta3 = new ContaCorrente();
conta3.DefinirSaldo (10);
Console.WriteLine(conta3.ObterSaldo());


