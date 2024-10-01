namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
         // Switch Case
         // Break -- default

            int day = 8;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Lunedì");
                    Console.WriteLine("Orario da seguire");
                    break;

                case 2:
                    Console.WriteLine("Martedì");
                    Console.WriteLine("Orario da seguire");
                    break;
                    
                case 3:
                    Console.WriteLine("Mercoledì");
                    Console.WriteLine("Orario da seguire");
                    break;

                case 4:
                    Console.WriteLine("Giovedì");
                    Console.WriteLine("Orario da seguire");
                    break;

                case 5:
                    Console.WriteLine("Venerdì");
                    Console.WriteLine("Orario da seguire");
                    break;

                case 6:
                    Console.WriteLine("Sabato");
                    Console.WriteLine("Orario da seguire");
                    break;

                case 7:
                    Console.WriteLine("Domenica");
                    Console.WriteLine("Orario da seguire");
                    break;

                default:
                    Console.WriteLine("Non esiste questo giorno della settimana!");
                    break;
            }
        }
    }
}
