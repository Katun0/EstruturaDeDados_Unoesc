using System.Collections;
using System.Runtime.InteropServices;

Hashtable table = new Hashtable();

Console.WriteLine("Início do Programa");

while(true)
{
    Console.WriteLine("Por favor, informe o CPF: ");
    string? cpf = Console.ReadLine();
    
    Console.WriteLine("Agora informe o nome: ");
    string? name = Console.ReadLine();

    try
    {
        table.Add(cpf,name);
    }
    catch(ArgumentException ar)
    {
        Console.WriteLine("ERRO! Valor inserido está repetido ou é inválido, por favor tente novamente");
        Console.WriteLine($"Detalhes do Erro: {ar}");
    }
    catch(Exception ex)
    {
        Console.WriteLine("Erro desconhecido, favor entrar em contato com o Suporte");
        Console.WriteLine($"Detalhes do Erro: {ex}");
    }
    
    Console.WriteLine("Deseja adicionar mais valores á tabela[S/N] ?");
    // Gambiarra das braba
    string? option = Console.ReadLine();
    option = option.ToUpper();
    if(option != "S")
    {
        break;
    }
}

foreach(DictionaryEntry de in table)
{
    Console.WriteLine("Relação CPF X Nome");
    Console.WriteLine($"{0}: {1}",de.Key, de.Value);
}