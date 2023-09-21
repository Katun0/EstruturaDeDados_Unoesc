using System.Collections;

// Criar HashTable

Hashtable openWith = new Hashtable();

openWith.Add("txt","notepad.exe");
openWith.Add("bmp","paint.exe");
openWith.Add("dib","paint.exe");
openWith.Add("rft","word.exe");

try
{
    openWith.Add("txt","notepad.exe");
}
catch(ArgumentException aex)
{
    Console.WriteLine("Ops... Você tentou adicionar uma chave inválida");
    Console.WriteLine($"Detalhes do erro {aex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine("Erro Genérico !");
    throw ex;
}

//Acessando o conteúdo da tabela hash
openWith["rtf"] = "winword.exe";
Console.WriteLine(
    "Na \\ chave = \"rtf\" é {0}",
    openWith["rtf"]
    );

//Testar se a chave existe
if(!openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Chave ht Adicionada.");
}

//Percorrendo hash com foreach
Console.WriteLine();

foreach( DictionaryEntry de in openWith )
{
    Console.WriteLine("Key = {0} - Value = {1}", de.Key, de.Value);
}

//Obtendo apenas os valores do hash
ICollection valueCol = openWith.Values;

Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("Value = {0}", s);
}

//Obtendo apenas as chaves do Hash
ICollection keyCol = openWith.Keys;

Console.WriteLine();
foreach(string s in keyCol)
{
    Console.WriteLine("Key = {0}", s);
}

//Removendo registro do hash

Console.WriteLine("Removendo \"doc\" ");
openWith.Remove("doc");

if(!openWith.ContainsKey("doc"))
{
    Console.WriteLine("Chave \"doc\" Foi Removida ");
}
