namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prima parte Dichiarazione For Each
            /*Il ciclo foreach in C# permette di enumerare gli elementi di una collezione, eseguendo un'azione per ogni elemento
             senza la necessità di gestire manualmente gli indici.
             La sintassi del ciclo foreach è semplice: foreach (tipo elemento in collezione) { // codice da eseguire }, 
             dove il 'tipo' rappresenta il tipo degli elementi nella collezione.
             Utilizzando il ciclo foreach si aumenta la leggibilità del codice e si riduce il rischio di errori, poiché non è necessario
             gestire gli indici degli array o delle liste. */

            string[] viaggio = { "Automobile", "Treno", "Bus", "Aereo", "Moto", "Nave" };

            foreach (string i in viaggio)
            {

                // Dichiarazione

                Console.WriteLine("Il tuo valore è: " + i);


                // Seconda parte Break e Continue
                if (i == "Bus")
                {
                    // Dichiarazione semplice

                    break; // Puoi sostituire con continue
                }
            }
        }
    }
}
