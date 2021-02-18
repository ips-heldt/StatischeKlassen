using System;
using System.Text;

namespace StatischeKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            int basis = 5;
            int exponent = -2;
            Console.WriteLine($"Die Potenz von {basis} hoch {exponent} beträgt: {Mathe.Potenz(basis, exponent)}");

            exponent = 2;
            Console.WriteLine($"Die Potenz von {basis} hoch {exponent} beträgt: {Mathe.Potenz(basis, exponent)}");

            exponent = 0;
            Console.WriteLine($"Die Potenz von {basis} hoch {exponent} beträgt: {Mathe.Potenz(basis, exponent)}");

            basis = 0;
            exponent = -2;
            Console.WriteLine($"Die Potenz von {basis} hoch {exponent} beträgt: {Mathe.Potenz(basis, exponent)}");

            basis = -10;
            exponent = -2;
            Console.WriteLine($"Die Potenz von {basis} hoch {exponent} beträgt: {Mathe.Potenz(basis, exponent)}");

            basis = 0;
            exponent = 2;
            Console.WriteLine($"Die Potenz von {basis} hoch {exponent} beträgt: {Mathe.Potenz(basis, exponent)}");

            int radius = 50;
            Console.WriteLine($"\nDer Umfang eines Kreises mit einem Radius von {radius}mm beträgt: {Mathe.KreisUmfang(radius)}\ngerundet auf 3 Stellen lautet das Ergebnis: {Mathe.Runden(Mathe.KreisUmfang(radius), 3)}mm");

            Console.WriteLine($"\nDie Kreisfläche eines Kreises mit einem Radius von {radius}mm beträgt: {Mathe.KreisFlaeche(radius)}\ngerundet auf 2 Stellen lautet das Ergebnis: {Mathe.Runden(Mathe.KreisFlaeche(radius), 2)}mm²");

            double wert = 29.89997;
            int stellen = 4;
            Console.WriteLine("\nDer auf {0} Stellen gerundete Wert von {1}, beträgt {2}", stellen, wert, Mathe.Runden(wert, stellen));

            Console.ReadKey();
        }
    }
}
