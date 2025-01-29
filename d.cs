/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 29/01/2025
 * Time: 09:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace d
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite três números: ");
			
			int n1, n2, n3;
			n1 = int.Parse(Console.ReadLine());
			n2 = int.Parse(Console.ReadLine());
			n3 = int.Parse(Console.ReadLine());
			
			if (n1 < n2) {
				Console.WriteLine("{0} é menor que {1}", n1, n2);
			} else {
				Console.WriteLine("{0} é menor que {1}", n2, n1);
			}
			
			if (n1 > n3) {
				Console.WriteLine("{0} é maior que {1}", n1, n3);
			} else {
				Console.WriteLine("{0} é maior que {1}", n3, n1);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}