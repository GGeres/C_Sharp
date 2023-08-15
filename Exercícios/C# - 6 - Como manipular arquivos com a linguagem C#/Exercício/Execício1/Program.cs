using System.Text;

var teste = "teste.txt";
var byteLido = -1;

var fs = new FileStream(teste, FileMode.Open);
var buffer = new byte[1024];


while(byteLido != 0)
{
    byteLido = fs.Read(buffer, 0, 1024);
    EscreverBuffer(buffer);
}

static void EscreverBuffer(byte[] buffer)
{
    var encoding = Encoding.ASCII;
    var conteudoArquivo = encoding.GetString(buffer);
    Console.Write(conteudoArquivo);
}






