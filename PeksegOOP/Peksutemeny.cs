using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeksegOOP
{
	internal abstract class Peksutemeny : IArlap
	{
		protected string neve;
		protected int ar;
		protected double mennyiseg;

		

		public Peksutemeny(string nave, int ar, double mennyiseg)
		{
			this.neve = nave;
			this.ar = ar;
			this.mennyiseg = mennyiseg;
		}
		public string Nave { get => neve; set => neve = value; }
		public int Ar { get => ar; set => ar = value; }
		public double Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

		public abstract void Megkostol();

		public int MennyibeKerul()
		{
			return (int)(this.ar * this.mennyiseg);
		}

		public override string ToString()
		{
			return $"{this.neve} {this.mennyiseg} darab/dkg {this.MennyibeKerul()} Ft";
		}

	}
}
