// 5. write C# program to calculate simple interest. Input data from user.

using System;
public class display{
public static void Main(string [] args){

Console.WriteLine("Enter principle: ");
float p = float.Parse(Console.ReadLine());
Console.WriteLine("Enter time: ");
float t = float.Parse(Console.ReadLine());
Console.WriteLine("Enter rate: ");
float r = float.Parse(Console.ReadLine());

Console.WriteLine("simple interest is " + (p*t*r)/100);
}}