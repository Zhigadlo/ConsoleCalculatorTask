using ConsoleCalculator.Exceptions;
using ConsoleCalculator.Interfaces;

namespace ConsoleCalculator.Operations
{
    public class Division : IOperation
    {
        private const int ParametersCount = 2;

        public double Call(params double[] args)
        {
            if (args.Length != ParametersCount)
                throw new WrongParametersCountException(ParametersCount);

            return args.First() / args.Last();
        }
    }
}
