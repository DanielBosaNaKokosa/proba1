using System.Globalization;

namespace pregorovmasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //string[] imena = new string[13];
            //int[] cxhisla = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //for (int i = 0; i < imena.Length; i++)
            //{
            //    Console.WriteLine(imena[i]);
            //}
            //foreach (int chisla in cxhisla)
            //{
            //    Console.WriteLine(chisla);
            //}
            //Console.WriteLine(string.Join(", ", imena));

            //Console.WriteLine("Vuvedi imena: ");
            //string[] imena2 = Console.ReadLine().Split(' ');
            //string naiDulgoime = imena2[0];
            //int indeks = 0;
            //for (int i = 1; i < imena2.Length; i++)
            //{
            //    if (imena2[i].Length > naiDulgoime.Length)
            //    {
            //        naiDulgoime = imena2[i];
            //        indeks = i;
            //    }
            //}
            //Console.WriteLine($"Най-дългото име е {naiDulgoime} на индекс {indeks}");
            //Console.Write("Kolko chisla shte vuvedesh: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] numbers = new int[n];
            //for(int i = 0; i < n; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int min = numbers[0];
            //int max = numbers[0];
            //int suma = 0;
            //foreach (int chislo in numbers)
            //{
            //    if (chislo < min)
            //    {
            //        min = chislo;
            //    }
            //    if (chislo > max)
            //    {
            //        max = chislo;
            //    }
            //    suma += chislo;
            //}
            //double sredno = (double)suma / n;
            //Console.WriteLine($"Min: {min}, Max: {max}, Sredno: {sredno}");

            //List<int> numbers = new List<int>();
            //List<string> imena = Console.ReadLine().Split(' ').ToList();
            //int input = int.Parse(Console.ReadLine());
            //while (input != 0)
            //{
            //    numbers.Add(input);
            //    input = int.Parse(Console.ReadLine());

            //}
            //foreach (int chisla in numbers)
            //{
            //    Console.WriteLine(chisla);
            //}
            //vuvedi ot klaviatrurata 5 puti

            //List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine("nums[" + i + "] = " + nums[i]);

            //}
            List<string> imena = Console.ReadLine().Split(' ').ToList();
            for (int i = imena.Count - 1; i >= 0; i--)
            {
                Console.Write(imena[i] + "; ");
            }
            //List<string> Hora = new List<string>(Console.ReadLine().Split(' ').ToList());
            //foreach (string ime in Hora)
            //{
            //   jkhgfff
            //    Console.Write();
            //}

        }
    }
}
