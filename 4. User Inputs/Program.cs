namespace UserInputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User Inputs in C#

            Console.WriteLine("Scrivi il tuo nome qui:");

            string nome = Console.ReadLine();

            Console.WriteLine("Benvenuto " + nome);

            Console.WriteLine("Scrivi il tuo numero di telefono qui:");

            string myNum = Console.ReadLine();

            Console.WriteLine(nome + ", il tuo numero è: " + myNum);
        }
    }
}
