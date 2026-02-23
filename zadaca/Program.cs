namespace zadaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            byte count = 1;
            byte maxcount = 0;
            int maxelem = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i]  == numbers[j])
                    {
                        count++;
                    }
                }
                if(count>maxcount)
                {
                    maxcount = count;
                    maxelem = numbers[i];
                }
                count = 1;
            }
            Console.WriteLine($"Max repeterelement e {maxelem} -> {maxcount} puti");
        }
    }
}
