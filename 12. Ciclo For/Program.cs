namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ciclo For
            /*Il ciclo for è un costrutto di controllo che permette di ripetere un blocco di codice un numero specificato di volte,
             *utilizzando un contatore per gestire le iterazioni.
             In C#, il ciclo for è comunemente utilizzato per iterazioni, dove si dichiara una variabile contatore, 
             si definisce una condizione di continuazione e si specifica un incremento.
             Il ciclo for esegue una valutazione iniziale, quindi verifica una condizione prima di eseguire il corpo del ciclo,
             rendendolo utile per operazioni ripetitive.*/

            for (int i = 0; i < 5; i++) // Prova (int i = 0; i<= 10; i = i + 2)
            {
                // Dichiarazione di esecuzuione

                Console.WriteLine("Il valore di I è: " + i);
            }
        }
    }
}
