namespace Stringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Stringhe in C#

            string nome = "Mario";

            string benvenuto = "Benvenuto in C#";

            string txt = "ABCDEFGHIJKLMNOPRSTUVWXYZ";

            Console.WriteLine("La lunghezza della stringa txt è: " + txt.Length); // 25

            string txt1 = "ABCdEFGHIJKLmNOpRSTUVWXYZ";

            Console.WriteLine("La lunghezza della stringa txt è: " + txt1.ToUpper()); // ABCDEFGHIJKLMNOPRSTUVWXYZ

            string txt2 = "ABCdEFGHIJKLmNOpRSTUVWXYZ";

            Console.WriteLine("La lunghezza della stringa txt è: " + txt2.ToLower()); // abcdefghijklmnoprstuvwxyz

            string cognome = "Rossi";
            string nominativo = nome + cognome;

            Console.WriteLine(nominativo); // MarioRossi

            string nominativofinale = string.Concat(nome, cognome);

            Console.WriteLine(nominativofinale); // MarioRossi

         //Proprietà delle stringhe

            //Indicizzazione
            string testo = "Esempio di testo";

            Console.WriteLine(testo[0]); // E
            Console.WriteLine(testo[1]); // s
            Console.WriteLine(testo.IndexOf("s")); // 1

            string testo1 = "Esempio di testo \n per comprendere le proprietà delle stringhe";

            Console.WriteLine(testo1); // \n va a capo mentre \t lascia uno spazio vuoto
        }
    }
}
