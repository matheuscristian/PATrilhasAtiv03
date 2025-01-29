/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 09:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace i
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite dois números: ");
			
			int n1, n2;
			n1 = int.Parse(Console.ReadLine());
			n2 = int.Parse(Console.ReadLine());
			
			if (n1 - n2 <= 10) {
				Console.WriteLine("A diferença dos números é menor ou igual a 10");
			} else {
				Console.WriteLine("A diferença dos números é maior que 10");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}