namespace PairImpairBoucle;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes
         * Demandez à l'utilisateur un nombre
         * Dites à l'utilisateur si le nombre fourni est pair ou impair
         * Demandez à l'utilisateur s'il veut proposer un autre nombre
         *  On lui permet de le faire lorsqu'il entre "y". Dans les autres cas, on termine le programme
         */
        bool isRunning = true;
        while (isRunning){
            Console.WriteLine("Entrez un nombre entier");
            int nbUser = Convert.ToInt32(Console.ReadLine());
            String EvenOdd;
            if (nbUser % 2 == 0)
            {
                EvenOdd = "pair";
            }
            else
            {
                EvenOdd = "impair";
            }
            Console.WriteLine($"{nbUser} est {EvenOdd}\nVoulez-vous écrire un autre nombre ? (tapez \"y\" pour en écrire un autre)");
            if (Console.ReadLine() != "y")
            {
                isRunning = false;
            }
        }


    }
}
