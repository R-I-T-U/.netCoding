// 3. write C# program to calculate area and perimeter of a rectangle using input from Console.ReadLine().

using System;
public class display{
public static void Main(string [] args){
Console.WriteLine("Enter length: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("Enter breadth: ");
float b = float.Parse(Console.ReadLine());

Console.WriteLine("Area is "+(a*b)+ " and perimeter is " + 2*(a+b));
}}