namespace find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvejdane nA elemtni i tursene na stojnost");
            List<string> imena = new List<string>();
            imena.Add("dIMITur");
            imena.Add("Petar");
            imena.Add("10" + 15);
            Console.WriteLine("Vuvedi 3 neshta ot klaviaturata");
            imena.Add(Console.ReadLine());
            imena.Add(Console.ReadLine());
            imena.Add(Console.ReadLine());
            Console.WriteLine("Vuvejdai imena dokato ne vuvedesh 'END' za krai");
            string input = Console.ReadLine();
            while (input != "END")
            {
                imena.Add(input);
                input = Console.ReadLine();
            }
            if (!imena.Contains("dIMITur"))
            {
                Console.WriteLine("Mitko NE e v spisuka");
            }
            if (imena.Contains("Martin"))
            {
                Console.WriteLine($"Martin e na {(imena.IndexOf("Martin"))}  v spisuka");
            }
            else
            {
                Console.WriteLine("Martin NE e v spisuka");
            }
            Console.WriteLine($"Martin go ima i na {imena.LastIndexOf("Martin")}");
            Console.WriteLine(string.Join(", ", imena));

        }
    }
}
