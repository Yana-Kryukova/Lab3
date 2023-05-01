// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
Console.WriteLine("Enter A, B, +, -, * or /");
string s = Console.ReadLine();
int A=0, B=0;
switch (s)
{
    case "A": A = int.Parse(Console.ReadLine());break;
    case "B": B = int.Parse(Console.ReadLine()); break;
    case "+":break;
    case "-": break;
    case "*": break;
    case "/": break;
}