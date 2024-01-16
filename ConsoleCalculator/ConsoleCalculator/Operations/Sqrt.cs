using ConsoleCalculator.Exceptions;
using ConsoleCalculator.Interfaces;

namespace ConsoleCalculator.Operations
{
    public class Sqrt : IOperation
    {
        private const int ParametersCount = 1;
        public double Call(params double[] args)
        {
            if (args.Length != ParametersCount)
                throw new WrongParametersCountException(ParametersCount);

            return Math.Sqrt(args[0]);
        }
    }
}
