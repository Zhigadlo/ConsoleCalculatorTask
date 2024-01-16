namespace ConsoleCalculator.Exceptions
{
    public class WrongParametersCountException : Exception
    {
        public WrongParametersCountException(int parameterCount) : base($"Parameter count must be {parameterCount}")
        {
        }
    }
}
