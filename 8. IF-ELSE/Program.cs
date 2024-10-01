namespace IFELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dichiarazioni IF-ELSE

            //int temp = 22; //  Primo valore della temperatura
            Console.WriteLine("Inserisci la temperatura esterna: "); //Secondo valore della temperatura
            
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp > 30)
            
            {
                Console.WriteLine("Oggi puoi andare a mare");
            }

            else if (temp < 20)
            {

                Console.WriteLine("Copriti");

            }
            else {
                Console.WriteLine("Giornata normale");
            }
        }
    }
}
