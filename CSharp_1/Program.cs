﻿
class Program
{

    // Statyczna metoda zwracająca wyliczony max z tablicy int
    static double GetMax(int[] tab)
    {
        if (tab.Length > 0)
        {
            double maxValue = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                if (maxValue < tab[i])
                    maxValue = tab[i];
            }
            return maxValue;
        }
        else throw new ArgumentException("Tablica musi zawierac elementy.", nameof(tab));

    // Statyczna metoda zwracająca wyliczoną średnią z tablicy int
    static double GetAverage(int[] tab)
    {
        double average = 0;
        for (int i = 0; i < tab.Length; i++)
        {
            average += tab[i];
        }
        return average / tab.Length;
    }

    static void Main(string[] args)
    {
        int[] tablica = { 10, 20, 30, 40, 50 };

        double maxValue = GetMax(tablica);
        Console.WriteLine("Max z tablicy: " + maxValue);

        double srednia = GetAverage(tablica);
        Console.WriteLine("Średnia z tablicy: " + srednia);
    }
}
