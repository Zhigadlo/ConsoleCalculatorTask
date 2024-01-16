using ConsoleCalculator.Exceptions;
using ConsoleCalculator.Interfaces;
using ConsoleCalculator.Operations;

Dictionary<string, IOperation> operations = new Dictionary<string, IOperation>
{
    { "+", new Addition() },
    { "-", new Substraction() },
    { "*", new Multiplication() },
    { "/", new Division() },
    { "sin", new Sin() },
    { "cos", new Cos() },
    { "tan", new Tan() },
    { "sqrt", new Sqrt() }
};

while (true)
{
    try
    {
        bool isOperationFound = false;
        IOperation operation;
        do
        {
            Console.Write("op: ");
            string @operator = Console.ReadLine();
            isOperationFound = operations.TryGetValue(@operator.ToLower(), out operation);
            
            if (!isOperationFound)
                throw new NoSuchOperationException();

        } while (!isOperationFound);

        bool isArgumentInputCorrect = false;
        string arguments;
        do
        {
            Console.Write("args: ");
            arguments = Console.ReadLine();
            isArgumentInputCorrect = arguments.Split(' ').All(s => double.TryParse(s, out _));
            if (!isArgumentInputCorrect)
                Console.WriteLine("String was in wrong format. Enter numbers separated by spaces...");
        } while (!isArgumentInputCorrect);


        var result = operation.Call(arguments.Split(' ').Select(double.Parse).ToArray());
        Console.WriteLine("result: " + result);
        Console.WriteLine();
        Console.WriteLine("=======================================");
        Console.WriteLine();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}