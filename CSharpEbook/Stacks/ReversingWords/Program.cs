using System;

Stack<char> chars = new Stack<char>();
foreach (char c in "LET'S REVERSE!")
{
    chars.Push(c);
}
while(chars.Count > 0)
{
    Console.Write(chars.Pop());
}
Console.WriteLine();