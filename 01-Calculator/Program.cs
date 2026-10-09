String? input;
Double a, b;
if (args.Length > 0)
{
    input = args[0];
    Console.WriteLine(input);
}
else
{
    input = Console.ReadLine();
    Console.WriteLine(input);
}
if (input == null)
{
    Console.WriteLine("No input provided.");
    return;
}
List<string> equationParts = input.Split(" ").ToList();
equationParts.RemoveAll(string.IsNullOrWhiteSpace);

if (equationParts.Count != 3)
{
    Console.WriteLine("Invalid input. Please provide an equation in the format: number operator number");
    return;
}
if (double.TryParse(equationParts[0], out a) == false || double.TryParse(equationParts[2], out b) == false)
{
    Console.WriteLine("Invalid input. Please provide valid numbers.");
    return;
}

if ((equationParts[1] == "/" || equationParts[1] == "%") && b == 0)
{
    Console.WriteLine("Division by zero is not allowed.");
    return;
}

switch(equationParts[1])
{
    case "+":
        Console.WriteLine(equationParts[0] + " + " + equationParts[2] + " = " + (a + b));
        break;
    case "-":
        Console.WriteLine(equationParts[0] + " - " + equationParts[2] + " = " + (a - b));
        break;
    case "*":
        Console.WriteLine(equationParts[0] + " * " + equationParts[2] + " = " + (a * b));
        break;
    case "/":
        Console.WriteLine(equationParts[0] + " / " + equationParts[2] + " = " + (a / b));
        break;
    case "%":
        Console.WriteLine(equationParts[0] + " % " + equationParts[2] + " = " + (a % b));
        break;
    default:
        Console.WriteLine("Invalid operator. Please use one of the following: +, -, *, /, %");
        break;
}