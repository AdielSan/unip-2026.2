using System;
					
public class Program
{

	public static void Main()
	{
		int number1=0;
		int number2=0;
		int resultado=0;

		Console.WriteLine("Olá, Bem-vindo a calculadora básica de soma!");
		Console.WriteLine("Digite o primeiro número inteiro: ");
		number1 = int.Parse(Console.ReadLine());

		Console.WriteLine("Digite o segundo número inteiro: ");
		number2 = int.Parse(Console.ReadLine());

		resultado = number1 + number2;

		Console.WriteLine("A soma de " + number1 + " mais o número " + number2 + " é igual a: " + resultado);
	}


}