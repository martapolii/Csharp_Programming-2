namespace DateClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(2024, 03, 01);
            Console.WriteLine(date);

            // increase days
            date.Add(2);
            Console.WriteLine(date);

            // increase days and months
            date.Add(2, 2);
            Console.WriteLine(date);

            // increase by another date
            Date date2 = new Date(1000, 12, 30);

            date.Add(date2);
            Console.WriteLine(date);

          


        }
    }
}
