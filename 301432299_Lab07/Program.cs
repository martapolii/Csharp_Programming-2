namespace _301432299_Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarLoan aCarLoan = new CarLoan
            {
                LoanNumber = 2649,
                LastName = "Polishchuk",
                LoanAmount = 20000.00,
                Make = "Ford",
                Year = 2005
            };

            Console.WriteLine($"Loan {aCarLoan.LoanNumber} for {aCarLoan.LastName} is for {aCarLoan.LoanAmount:C2}.");
            Console.WriteLine($"Loan {aCarLoan.LoanNumber} is for a {aCarLoan.Year} {aCarLoan.Make}.");
        }
    }
}
