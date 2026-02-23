namespace spisuci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Vuvedi chisla ot klaviaturata, (0 za stop)");
            int number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                numbers.Add(number);
                number = int.Parse(Console.ReadLine());
            }

            //numbers.Add(9);
            //numbers.Add(11);
            //numbers.Add(83);
            //numbers.Add(12);
            //numbers.Add(33);
            ////Console.WriteLine(numbers.Count);
            //numbers.Insert(2, 16);
            //numbers.Insert(4, 17);
            //numbers.Insert(3, 19);
            //numbers.Insert(5, 14);
            //Console.WriteLine(numbers.Count);
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            for (int index = 0; index <= numbers.Count; index++)
            {
                Console.WriteLine($"{index} ----> {numbers[index]}");
            }
        }
    }
}
