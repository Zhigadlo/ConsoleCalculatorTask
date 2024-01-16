namespace ConsoleCalculator.Exceptions
{
    public class TooManyParametersException : Exception
    {
        public TooManyParametersException(int maxParameterCount) : base($"Parameter count must be less then {maxParameterCount}")
        {
        }
    }
}
