using ConsoleCalculator.Exceptions;
using ConsoleCalculator.Interfaces;

namespace ConsoleCalculator.Operations
{
    public class Multiplication : IOperation
    {
        private const int MinParameterCount = 2;
        public double Call(params double[] args)
        {
            if (args.Length < MinParameterCount)
                throw new TooFewParametersException(MinParameterCount);

            double multiplication = 1;
            foreach (var item in args)
                multiplication *= item;
            
            return multiplication;
        }
    }
}
