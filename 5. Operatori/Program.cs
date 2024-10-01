namespace Operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Operatori matematici

            int tot1 = 100 + 100;  
            Console.WriteLine(tot1);  //200

            int tot2 = tot1 + 250; 
            Console.WriteLine(tot2);  //450

            int tot3 = tot2 + tot2; 
            Console.WriteLine(tot3);  //900

            // + addizione
            // - sottrazione
            // * moltiplicazione
            // / divisione
            // % modulo
            // ++ incremento di valore 1
            //-- decremento di valore 1

            //Operatori di assegnazione

            tot1 += 50;
            Console.WriteLine(tot1);  //250

            tot1 -= 50;
            Console.WriteLine(tot1);  //200

            tot1 *= 2;
            Console.WriteLine(tot1);  //400

            //Operatori di comparazione

            // == uguale a          x == y
            // != diverso da        x != y
            // > maggiore di        x > y
            // < minore di          x < y
            // >= maggiore uguale   x >= y
            // <= minore uguale     x <= y

            //Operatori logici

            // && AND  fornisce VERO se le due condizioni sono vere          x < 5 && x < 100
            // || OR   fornisce VERO se una delle due condizioni sono vere   x < 5 || x < 4
            // !  NOT  ribalta il risultato, FALSO se il risultato è VERO    !(x < 5 && x < 10) 
        }
    }
}
