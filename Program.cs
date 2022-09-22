namespace Calculator2_Lexicon_Assignment
{
    internal class Program
    {
        public static double? AskAndReceiveADouble()
        {
            try
            {
                Console.WriteLine("Enter a 'double' value: ");
                string? input = Console.ReadLine();
                double? val = double.Parse(input);
                return val;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Hint: 'double' values are written with a comma(,) separator and not a period(.)");
                Console.WriteLine("Hint: We're talking numbers, not characters.");
                Console.WriteLine(ex.Message);
                Console.WriteLine("Stacktrace: " + ex.StackTrace);
                throw new Exception(ex.Message);
            }
        }
        static void Main(string[] args)
        {
            double[] vals = { -2, -2, 3, 0 };
            Console.WriteLine(Calc.Addition(vals));
            Console.WriteLine(Calc.Subtraction(vals));
            Console.WriteLine(Calc.Multiplication(vals));
            Console.WriteLine(Calc.Division(vals));
            Console.WriteLine(AskAndReceiveADouble());
        }
    }
}