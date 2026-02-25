namespace TestRezultati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi rezultati ot testa (0-100)");
            int[] nums = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int maxRezultat = nums[0];
            int minRezultat = nums[0];
            int sumRezultat = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxRezultat)
                {
                    maxRezultat = nums[i];
                }
                if (nums[i] < minRezultat)
                {
                    minRezultat = nums[i];
                }
                sumRezultat += nums[i];
            }   
            double Avg = (double)sumRezultat / nums.Length;
            int broiUcenici = nums.Length;
            for(int i = broiUcenici-1; i >= 0; i--)
            {
                if(nums[i] < Avg)
                {
                    broiUcenici--;
                }
            }
            Console.WriteLine($"Najvisok rezultat: {maxRezultat}");
            Console.WriteLine($"Najnisok rezultat: {minRezultat}");
            Console.WriteLine($"Sredniq rezultat: {Avg}");
            Console.WriteLine($"Broj na ucenici so rezultat nad sredniot: {broiUcenici}");
            Array.Sort(nums);
            Console.WriteLine($"Sortirani rezultati: {string.Join(", ", nums)}");
        }
    }
}
