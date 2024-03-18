
class Program
{
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

        double srednia = GetAverage(tablica);
        Console.WriteLine("Średnia z tablicy: " + srednia);
    }
}