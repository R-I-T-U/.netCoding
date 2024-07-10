// 2. write C# program to add , subtract, multiply and division of 2 number using input from command line.

using System;
public class display{
public static void Main(string [] args){
int a = int.Parse(args[0]);
int b = int.Parse(args[1]);


Console.WriteLine("Sum is "+(a+b));
Console.WriteLine("Substraction is "+(a-b));
Console.WriteLine("multiple is "+(a*b));
Console.WriteLine("division is "+(a/b));


}}