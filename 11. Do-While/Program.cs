namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ciclo Do-While
            /*L'istruzione do-while esegue un blocco di istruzioni almeno una volta e poi controlla la condizione per decidere
             * se ripetere il ciclo. Questo la differenzia dal ciclo while, dove la condizione è verificata prima dell'esecuzione.
             In C#, il ciclo do-while è utile quando si desidera garantire che il codice all'interno del ciclo venga eseguito
             almeno una volta prima di verificare la condizione.
             Un esempio tipico di utilizzo è quello di richiedere all'utente di inserire un valore finché non è valido, 
             dove si vuole assicurare che ci sia almeno un tentativo di inserimento.
             Differisce dal while perché esegue sempre la prima iterazione.*/

            int i = 1;

            do
            {           

            // Dichiarazione
            Console.WriteLine(i);
            i++;  // incrementa il valore di i di +1

            } while (i < 10);


            Console.WriteLine("Il ciclo è terminato!");
        }
    }
}
