/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 09:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace h
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			
			int n1;
			n1 = int.Parse(Console.ReadLine());
			
			if (n1 >= 0) {
				Console.WriteLine("{0} é positivo.", n1);
			} else {
				Console.WriteLine("{0} é negativo.", n1);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}