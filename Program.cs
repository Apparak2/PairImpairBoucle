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

        int testedNumber;
        string continueTesting;
        
        do
        {
            Console.WriteLine("> Veuillez insérer un nombre entier : ");
            testedNumber = Convert.ToInt32(Console.ReadLine());

            if (testedNumber % 2 == 0) {
                Console.WriteLine("Le nombre donné est pair");
            } else {
                Console.WriteLine("Le nombre donné est impair");
            }

            // Maintenant que le nombre a été testé, on propose d'en vérifier un autre
            Console.WriteLine("\n> Voulez-vous vérifier un autre nombre ? (y/n)");
            continueTesting = Console.ReadLine(); // Permet de changer la valeur de continueTesting
            Console.WriteLine("");
        } while (continueTesting == "y" || continueTesting == "Y");
    }
}
