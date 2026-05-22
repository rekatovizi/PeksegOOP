namespace PeksegOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pogacsa p1 = new Pogacsa("sajtos pogi", 230, 5);
			Console.WriteLine(p1);
            p1.Megkostol();
            Console.WriteLine(p1);

            Teasutemeny t = new Teasutemeny("teasüti", 100, 15, "csokis");
            Teasutemeny t1 = new Teasutemeny("teasüti", 100, 15, "baracklekváros");
            Pogacsa p2 = new Pogacsa("tepertős pogi", 230, 5);

            p2.Megkostol();
            Console.WriteLine(p2);
            t.Megkostol();
            Console.WriteLine(t);
            t1.Megkostol();
            Console.WriteLine(t1);

            Croissant c = new Croissant("croissant", 300, 10, " lekváros");
            c.Megkostol();
            Console.WriteLine(c);
		}
    }
}
