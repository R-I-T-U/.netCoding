// 4. write C# program to convert degree celcius to Fahrenheit using input from user.

using System;
public class display{
public static void Main(string [] args){

Console.WriteLine("Enter temperature(in celcius): ");
float c = float.Parse(Console.ReadLine());
Console.WriteLine("into fahrenheit : " + (c*1.8f)+32);
}}