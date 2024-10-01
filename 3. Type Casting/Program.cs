namespace Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Type Casting in C#
            string nome = "Mario";

            //Implicit Casting (automatico)
            //char -> int -> long -> float -> double


            //Explicit Casting (manuale)
            //double -> float -> long -> int -> char

            int myInt = 8;
            double myDouble = myInt;

            Console.WriteLine(myDouble);

            double mydouble = 9.9;
            //int myint = mydouble; non è possibile convertire
            int myint = (int)mydouble;

            Console.WriteLine(myint);

            //Metodo di conversione di tipo
            //Convert.To...
          
            int myInt2 = 9;
            double myDouble2 = 20.77;

            Console.WriteLine(Convert.ToDecimal(myInt2)); //non è possibile
            Console.WriteLine(Convert.ToInt32(myDouble2));

        }
    }
}
