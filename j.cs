/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 09:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace j
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			
			double n1;
			n1 = Double.Parse(Console.ReadLine());
			
			if (n1 == 0) {
				Console.WriteLine("{0} é igual a 0.", n1);
			} else {
				Console.WriteLine("{0} é diferente de zero.", n1);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}