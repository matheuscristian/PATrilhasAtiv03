/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 09:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace e
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite dois números: ");
			
			double n1, n2;
			n1 = Double.Parse(Console.ReadLine());
			n2 = Double.Parse(Console.ReadLine());
			
			if (n1 > n2) {
				Console.WriteLine("{0} é maior que {1}", n1, n2);
			} else if (n1 == n2) {
				Console.WriteLine("{0} é igual {1}", n1, n2);
			} else {
				Console.WriteLine("{0} é maior que {1}", n2, n1);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}