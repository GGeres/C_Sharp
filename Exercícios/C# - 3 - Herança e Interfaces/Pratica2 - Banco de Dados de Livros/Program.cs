using Pratica2___Banco_de_Dados_de_Livros.Estilo_Literário;
using Pratica2___Banco_de_Dados_de_Livros.Informações_Necessarias;


Aventura Brumas = new Aventura("856.852");
Brumas.Autor = "Harry Longtrade";
Brumas.Titulo = "As Brumas de Arthur";
Brumas.Estilo = "Aventura";
Brumas.numPag = 568;
Brumas.anoPubli = 1256;
Brumas.paisPubli = "Inglaterra";

Terror exor = new Terror("595.666");
exor.Autor = "William Peter Blatty";
exor.Titulo = "O Exorcista";
exor.Estilo = "Terror";
exor.numPag = 320;
exor.anoPubli = 1971;
exor.paisPubli = "Estados Unidos da América";

Console.WriteLine("Livros registrados: "+Brumas.Titulo+", "+exor.Titulo);
Console.WriteLine("Total de livros registrados: "+InfosObrig.TotLivros);