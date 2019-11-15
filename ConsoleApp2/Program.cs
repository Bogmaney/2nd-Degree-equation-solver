using System;
using System.Collections;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiterChars = { ' ', '=', '^', 'x', 'X','+' };
            string Bruh = Console.ReadLine();
            ArrayList ar = new ArrayList();

			string[] tests = Bruh.Split(delimiterChars);
            
			//Mangler stadig et for loop
			foreach (var test in tests)
			{
				if (test == "")
				{
					continue;
				} else
				{
					ar.Add(test);
				}
			}

			int c = ar.Count;
            Console.WriteLine(c);
            double Ligmed = Convert.ToDouble(ar[c-1]);
            double Ligmed1 = Convert.ToDouble(ar[c-2]);
            double A = Convert.ToDouble(ar[2]);
            double B = Convert.ToDouble(ar[0]);
            double C = Ligmed1 - Ligmed;
            double D = Math.Pow(B, 2) - 4 * A * C;
            Console.WriteLine("Discriminanten: " + D);
            double Løsning1 = -B + Math.Sqrt(D);
            double Løsning2 = -B - Math.Sqrt(D);
            if (D > 0) {
                Console.WriteLine("Plus Løsning: {0}" + "\nMinus Løsning: {1}", Løsning1, Løsning2);
            }
            if (D < 0)
            {
                Console.WriteLine("Ingen Maginær Løsning");
            }
            if (D == 0)
            {
                if (Løsning1 != 0)
                {
                    Console.WriteLine("Den eneste Løsning er plus løsning som er " + Løsning1);
                }
                else
                {
                    Console.WriteLine("Den eneste løsning er minus løsningen som er " + Løsning2);
                }
            }

        }
    }
}
