namespace _1._Variabili
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Type nomevariabile = Value;
            //string nome = "";
            string nome = "Mario";
            string telefono = "3334589763";
            Console.WriteLine(nome);
            Console.WriteLine(telefono);
            Console.WriteLine("Ciao " + nome); Console.WriteLine("Il mio numero di telefono è " + telefono);

            string cognome = "Rossi";
            string nominativo = nome + cognome;
            Console.WriteLine("Benvenuto " + nominativo);

            int numero = 10;
            Console.WriteLine(numero);
           
            double decimale = 10.533;
            Console.WriteLine(decimale);

            char lettera = 'S';
            Console.WriteLine(lettera);

            bool booleano = false;

            int a = 10;
            int b = 5;
            int c = a + b;
            Console.WriteLine("La somma di a e b è " + c); //15

            string a1 = "10";
            string b1 = "5";
            string c1 = a1 + b1;
            Console.WriteLine(c1); //105

            int a2 = 10, b2 = 20, c2 = 30; //60
        }
    }
}
