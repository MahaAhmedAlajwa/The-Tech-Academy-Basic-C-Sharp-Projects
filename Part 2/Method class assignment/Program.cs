using System;   // 🎯 Pulling in System so we can use Console and other core features.

namespace DemoApp
{
    // 🏗️ This class is our custom blueprint that holds the special method we're required to create.
    class MathWorker
    {
        // ⚙️ This void method accepts two integers.
        // 👉 It performs a math operation on the *first* integer.
        // 👉 It displays the *second* integer to the screen.
        public void ProcessNumbers(int firstNumber, int secondNumber)
        {
            // 🔢 Doing a simple math operation on the first integer. (Multiply by 2 for demo purposes.)
            int result = firstNumber * 2;

            // 📣 Showing the result of the math operation.
            Console.WriteLine($"The result of the math operation on the first number ({firstNumber}) is: {result}");

            // 👀 Displaying the second integer directly, as required.
            Console.WriteLine($"The second number you passed in is: {secondNumber}");
        }
    }

    class Program
    {
        // 🚪 Main entry point of the program—execution begins here.
        static void Main(string[] args)
        {
            // 🎉 Creating (instantiating) an object from the MathWorker class.
            MathWorker worker = new MathWorker();

            // 📞 Calling the method normally with two integer values.
            worker.ProcessNumbers(10, 25);

            // 🎯 Calling the same method but specifying parameter names explicitly.
            worker.ProcessNumbers(firstNumber: 7, secondNumber: 99);

            // 🏁 Keeping console window open (optional quality-of-life feature).
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
