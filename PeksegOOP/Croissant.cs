using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksegOOP
{
	internal class Croissant : Peksutemeny
	{
		private string toltelek;
		public Croissant(string nave, int ar, double mennyiseg, string toltelek) : base(nave, ar, mennyiseg)
		{
			this.toltelek = toltelek;
		}

		public string Toltelek { get => toltelek; set => toltelek = value; }

		public override void Megkostol()
		{
			this.mennyiseg -= 0.5;
			Console.WriteLine($"A {this.toltelek} croissant nagyon finom");
		}
		public override string ToString()
		{
			return base.ToString() + this.toltelek;
		}
	}
}
