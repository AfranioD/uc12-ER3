using CadastroPessoaUc12.Classes;

PessoaFisica novaPf =new PessoaFisica();
PessoaFisica metodosPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();

novaPf.Nome = "Afranio Dimas";
novaPf.dataNasc = new DateTime(2000, 01, 01);
novaPf.Cpf = "1234567890";
novaPf.Rendimento = 8500.5f;

novoEndPf.Logradouro = "5th Avenue Park";
novoEndPf.numero = 1485;
novoEndPf.complemento = "5th on the Park";
novoEndPf.endComercial = true;

novaPf.Endereco = novoEndPf;

Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.numero}
Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
");

// Console.WriteLine(novaPf.Nome);

// Console.WriteLine($"Nome: {novaPf.Nome}");
