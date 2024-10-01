namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            /* Gli arrays (matrici o vettori) indicano una struttura di dati formata da più componenti ordinati dello stesso tipo
               e identificate ognuna da uno o più indici che ne determinano univocamente la posizione*/

            string[] viaggio = { "Automobile", "Treno", "Bus", "Aereo", "Moto", "Nave" };
            int[] myNum = { 10, 5, 20, 1, 30, 7 };

            //viaggio[0] = "Nessun mezzo di trasporto";

            Console.WriteLine(viaggio[0]);

            Console.WriteLine(myNum[0]);

            Console.WriteLine("Gli elementi presenti nel mio array sono: " + viaggio.Length); // Per conoscere il numero degli elementi presenti nel vettore

            // Arrays usando il ciclo for per visualizzare tutti gli elementi presenti

            for (int i = 0; i < viaggio.Length; i++)
            {
                Console.WriteLine(viaggio[i]);
                Console.WriteLine("\t" );
            }

            // Arrays usando il ciclo foreach per visualizzare solo gli elementi che desidero
            // La procedura Sort effettua l'ordinamento degli elementi contenuti nell'array
           
            Array.Sort(viaggio);

            foreach (string i in viaggio)
            {
                Console.WriteLine(i);
            }

            // Possiamo provarlo anche con myNum

            Array.Sort(myNum);

            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }
        }
    }
}