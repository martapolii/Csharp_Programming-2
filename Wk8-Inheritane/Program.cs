namespace Wk8_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Letter l = new Letter();
            l.RecepientName = "Marta";
            l.DateMailed = "2024-07-11";

            Console.WriteLine(l.ToString());

            CertifiedLetter c = new CertifiedLetter();
            c.RecepientName = "John";
            c.DateMailed = "2024-01-01";
            c.TrackingNumber = 10000;
            Console.WriteLine(c.ToString());
        }
    }
}
