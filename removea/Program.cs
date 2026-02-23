using System.Globalization;

namespace removea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // da se vuvedat chisla vuv spisuk na edin red v klaviaturata
            // vtoro vuvejdane na edno chislo koeto da bude iztrito vseki put kogato se sreshtne
            List<int> numbers = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            Console.WriteLine("Vuvedi spisuka chislo po chislo");
            int Chislo = int.Parse(Console.ReadLine());
            while (Chislo != 0)
            {
                numbers.Add(Chislo);
                Console.WriteLine("Sledvashto chislo");
                Chislo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Chislo za tursene i iztrivane");
            int chislaZaMahane = int.Parse(Console.ReadLine());
            int indx = 0;
            while (numbers.Contains(chislaZaMahane))
            {
                numbers.Remove(chislaZaMahane);
            }

            //while (numbers.IndexOf(chislaZaMahane) != -1)
            //{
            //    //numbers.RemoveAt(numbers.IndexOf(chislaZaMahane));
            //    numbers.Remove(chislaZaMahane);
            //}

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
