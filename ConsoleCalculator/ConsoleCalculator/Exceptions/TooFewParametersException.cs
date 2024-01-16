namespace ConsoleCalculator.Exceptions
{
    public class TooFewParametersException : Exception
    {
        public TooFewParametersException(int minParameterCount) : base($"Parameter count must be equal or more then {minParameterCount}")
        {
        }
    }
}
