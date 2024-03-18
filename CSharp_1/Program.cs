
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
    }

    static void Main(string[] args)
    {
        int[] tablica = { 10, 20, 30, 40, 50 };

        double maxValue = GetMax(tablica);
        Console.WriteLine("Max z tablicy: " + maxValue);
    }
}
