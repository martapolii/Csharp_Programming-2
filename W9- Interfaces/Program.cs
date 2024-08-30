namespace W9__Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // want to declare objects of 3 types:

            Patient aPatient = new Patient();
            Upholsterer anUpholsterer = new Upholsterer();
            FootballPlayer aFootballPlayer = new FootballPlayer();

            Console.Write("The patient says: ");
            aPatient.Recover();

            Console.Write("The upholsterer says: ");
            anUpholsterer.Recover();

            Console.Write("The football player says: ");
            aFootballPlayer.Recover();

            Console.ReadKey();
        }
    }
}
