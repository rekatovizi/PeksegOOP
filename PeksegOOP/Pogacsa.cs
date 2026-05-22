using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksegOOP
{
	internal class Pogacsa : Peksutemeny
	{
		public Pogacsa(string nave, int ar, double mennyiseg) : base(nave, ar, mennyiseg)
		{
		}

		public override void Megkostol()
		{
			this.mennyiseg /= 2;
			Console.WriteLine($"A {this.neve} nagyon finom");
		}
	}
}
