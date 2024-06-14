// double num1 = 0; double num2 = 0;

// Console.WriteLine("Console Calculator in C#\r");
// Console.WriteLine("------------------------\n");

// Console.WriteLine("Type a number, and then press Enter");
// num1 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Type another number, and then press Enter");
// num2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Choose an option from the following list:");
// Console.WriteLine("\ta - Add");
// Console.WriteLine("\ts - Subtract");
// Console.WriteLine("\tm - Multiply");
// Console.WriteLine("\td - Divide");
// Console.Write("Your option? ");

// // Use a switch statement to do the math.
// switch (Console.ReadLine())
// {
//     case "a":
//         Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
//         break;
//     case "s":
//         Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
//         break;
//     case "m":
//         Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
//         break;
//     case "d":
//         // Ask user to enter a non-zero divisor
//         while (num2 == 0)
//         {
//             Console.WriteLine("Enter a non-zero divisor: ");
//             num2 = Convert.ToInt32(Console.ReadLine());
//         }
//         Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
//         break;

// }

// // Wait for the user to respond before closing.
// Console.Write("Press any key to close the Calculator console app...");
// Console.ReadKey();

class Calculator
{
    public static double DoOperation(double num1, double num2, string op)
    {
        double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

        // Use a switch statement to do the math.
        switch (op)
        {
            case "a":
                result = num1 + num2;
                break;
            case "s":
                result = num1 - num2;
                break;
            case "m":
                result = num1 * num2;
                break;
            case "d":
                // Ask the user to enter a non-zero divisor.
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                break;
            // Return text for an incorrect option entry.
            default:
                break;
        }
        return result;
    }
}

