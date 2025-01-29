/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 09:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace f
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			
			int n1;
			n1 = int.Parse(Console.ReadLine());
			
			if (n1 % 2 == 0) {
				Console.WriteLine("{0} é par.", n1);
			} else {
				Console.WriteLine("{0} é ímpar.", n1);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}