using System;

class Program
{
    static void Main()
    {
        while (true) 
        {
            Console.WriteLine("enter number 1:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter number 2 :");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter operation (plus, minus, divide, multiply) or 'exit' for exit:");
            string operation = Console.ReadLine().ToLower(); 

            if (operation == "exit") 
            {
                Console.WriteLine("program end");
                break; 
            }

            int result = 0;

            if (operation == "plus")
            {
                result = num1 + num2;
            }
            else if (operation == "minus")
            {
                result = num1 - num2;
            }
            else if (operation == "multiply")
            {
                result = num1 * num2;
            }
            else if (operation == "divide")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("no you cant divide by zero");
                    continue; 
                }
            }
            else
            {
                Console.WriteLine("problem!");
                continue; 
            }

            Console.WriteLine( result);
            Console.WriteLine(); 
        }
    }
}
