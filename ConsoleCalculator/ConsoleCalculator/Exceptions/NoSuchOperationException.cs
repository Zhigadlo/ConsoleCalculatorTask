namespace ConsoleCalculator.Exceptions
{
    public class NoSuchOperationException : Exception
    {
        public NoSuchOperationException() : base("There is no such operation...")
        {
        }
    }
}
