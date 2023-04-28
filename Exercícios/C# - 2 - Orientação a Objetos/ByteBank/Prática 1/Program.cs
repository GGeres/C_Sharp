using Prática_1;

Produto prodx = new Produto();
prodx.nomeProd = "Leite Moça";
prodx.fabricante = "Nestlé";
prodx.codBarras = "8949461894984";
prodx.unidade = 5;
prodx.valorUnit = 8.50;
prodx.valorCompra = (prodx.unidade * prodx.valorUnit);
prodx.estoque = 80;

Console.WriteLine(prodx.codBarras);


