using ConsoleCalculator.Exceptions;
using ConsoleCalculator.Interfaces;

namespace ConsoleCalculator.Operations
{
    public class Addition : IOperation
    {
        private const int MinParameterCount = 2;
        public double Call(params double[] args)
        {
            if (args.Length < MinParameterCount)
                throw new TooFewParametersException(MinParameterCount);

            return args.Sum();
        }
    }
}
