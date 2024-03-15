string operators;
double number1, number2;
double result = 0;

Console.Write("Number 1:");
number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Operator:");
operators = Console.ReadLine();
Console.Write("Number 2:");
number2 = Convert.ToDouble(Console.ReadLine());




switch (operators)
{
    case "+":
        result = number1 + number2;
        Console.WriteLine(number1 + " " + operators + " " + number2 + " = " + result);


        break;
    case "-":
        result = number1 - number2;
        Console.WriteLine(number1 + " " + operators + " " + number2 + " = " + result);
        break;
    case "*":
        result = number1 * number2;
        Console.WriteLine(number1 + " " + operators + " " + number2 + " = " + result);
        break;

    case "/":
        if (number2 == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            break;
        }
        result = number1 / number2;
        Console.WriteLine(number1 + " " + operators + " " + number2 + " = " + result);
        break;

    default:
        Console.WriteLine("Operator is not found");
        break;
}