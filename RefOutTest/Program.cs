namespace RefOutTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mathOperations = new MathOperation();
            int updateSubject = 5;
            Console.WriteLine($"before update {updateSubject} ");
            mathOperations.UpdateValue(ref updateSubject, 12);
            Console.WriteLine($"after update {updateSubject} ");

            double toSQ = 81;
            double result;
            mathOperations.CalculateSquareRoot(toSQ, out result);
            Console.WriteLine($"sqrt of {toSQ} is {result}");
            var tmp = result;

            var powValue = 3;
            mathOperations.CalculatePower(result, powValue, out result);
            Console.WriteLine($"{tmp} to power of {powValue} is {result}");


        }

        class MathOperation
        {
            public void UpdateValue(ref int subject, int increment)
            {
                subject += increment;
            }

            public void CalculateSquareRoot(double input, out double result)
            {
                result = Math.Sqrt(input);
            }

            public void CalculatePower(in double baseNumber, in int exponent, out double result)
            {
                //baseNumber++; error - "in" parameters are readonly
                result = Math.Pow(baseNumber, exponent);
            }
        }
    }
}
