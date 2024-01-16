using ConsoleCalculator.Exceptions;
using ConsoleCalculator.Interfaces;
namespace ConsoleCalculator.Operations
{
    public class Substraction : IOperation
    {
        private const int ParameterCount = 2;
        public double Call(params double[] args)
        {
            if (args.Length != ParameterCount)
                throw new WrongParametersCountException(ParameterCount);

            return args.First() - args.Skip(1).Sum();
        }
    }
}
