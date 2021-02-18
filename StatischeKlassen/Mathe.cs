using System;

namespace StatischeKlassen
{
    public static class Mathe
    {
        const double PI = 3.14159;

        public static double KreisUmfang(double Radius)
        {
            return PI * 2 * Radius;
        }

        public static double KreisFlaeche(double Radius)
        {
            return PI * Potenz(Radius, 2);
        }

        public static double Potenz(double Basis, int Exponent)
        {
            if ((Basis == 0) && (Exponent < 0))
            {
                return double.PositiveInfinity;// throw new Exception($"Error [Basis={Basis} und Exponent={Exponent}]");
            }

            if (Basis == 0) return 0;

            double Ergebnis = 1;

            // wenn Basis = 0 und Exponent = 0 dann Ergebnis = 1
            if (Exponent == 0) return Ergebnis;

            // wenn Exponent negativ dann eine Division ausführen
            if (Exponent < 0)
            {
                for (int i = 0; i > Exponent; i--)
                {
                    Ergebnis /= Basis;
                }
                return Ergebnis;
            }

            // sonst Multiplizieren
            for (int i = 0; i < Exponent; i++)
            {
                Ergebnis *= Basis;
            }
            return Ergebnis;
        }

        public static double Runden(double Wert, int Stellen)
        {
            int KommaPos = 0;
            int KommaStellen = 0;
            double NachkommaWert = 0;

            // Position der Kommastelle
            KommaPos = Convert.ToString(Wert).IndexOf(',');
            if(KommaPos < 0)
            {
                return Wert;
            }
            // Wieviele Kommastellen hat die Zahl
            KommaStellen = Convert.ToString(Wert).Length - KommaPos - 1;

            // Wenn die angegebene Stelligkeit größer als die Anzahl Nachkommastellen ist 
            // wird die Zahl 1:1 zurückgegeben
            if (KommaStellen <= Stellen)
            {
                return Wert;
            }

            // Kommastelle um x Stellen nach rechts verschieben
            for(int i = 1; i <= Stellen; i++)
            {
                Wert = Wert * 10;
            }

            // Neue Position der Kommastelle
            KommaPos = Convert.ToString(Wert).IndexOf(',');

            // Den Nachkommastellenwert speichern
            NachkommaWert = Convert.ToDouble(Convert.ToString(Wert).Substring(KommaPos));

            // Prüfen ob der Nachkommastellenwert >= 0.5 ist, was zum Aufrunden führt
            if(NachkommaWert >= 0.5) Wert += 1;

            // Zwischenspeicherung der Vorkommastellen
            Wert = Convert.ToDouble(Convert.ToString(Wert).Substring(0, KommaPos));

            // Kommastelle um x Stellen nach links verschieben
            for (int i = 1; i <= Stellen; i++)
            {
                Wert = Wert / 10;
            }

            return Wert;
        }
    }
}
