using System;

class Program
{
    static void Main()
    {
        // Display student information
        Console.WriteLine("Student: Ali Al Gasat");
        Console.WriteLine("Method Class Assignment\n");
        
        // Instantiate the MathOperations class
        MathOperations calculator = new MathOperations();
        
        // Call the method using positional parameters
        Console.WriteLine("First method call (positional parameters):");
        calculator.PerformMathOperation(8, 3);
        
        // Call the method using named parameters
        Console.WriteLine("\nSecond method call (named parameters):");
        calculator.PerformMathOperation(secondNumber: 5, firstNumber: 12);
        
        // Keep console open until user presses Enter
        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}

/// <summary>
/// Class containing mathematical operations
/// </summary>
class MathOperations
{
    /// <summary>
    /// Performs a math operation on the first integer and displays the second integer
    /// </summary>
    /// <param name="firstNumber">Integer to perform math operation on</param>
    /// <param name="secondNumber">Integer to display to the screen</param>
    public void PerformMathOperation(int firstNumber, int secondNumber)
    {
        // Perform math operation: Square the first number
        int result = firstNumber * firstNumber;
        
        // Display the operation performed and result
        Console.WriteLine($"Math operation: {firstNumber} squared = {result}");
        
        // Display the second integer parameter
        Console.WriteLine($"Second number displayed: {secondNumber}");
        
        // Bonus: Show how both numbers can be used together
        Console.WriteLine($"Bonus calculation: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
    }
}
