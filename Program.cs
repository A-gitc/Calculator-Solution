namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> Operater = new List<String> { "Addition", "Subtraction", "Multiplication", "Division", "Exit" };
            Console.WriteLine("Welcome to the Simple Calculator!");
            for (int i = 0; i < Operater.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Operater[i]}");
            }
            //This variable to lock the while loop
            //so the while loop will infinite if the flag doesn't change
            bool flag = true;
            while (flag)
            {
                Console.Write("Select an operation (1-5): ");
                int choise = int.Parse(Console.ReadLine());
                Console.Write("Enter the first operand: ");
                int first_operand = int.Parse(Console.ReadLine());
                Console.Write("Enter the second operand: ");
                int second_operand = int.Parse(Console.ReadLine());

                if (choise == 1)
                {
                    Console.WriteLine($"Result: {first_operand + second_operand}");
                }
                else if (choise == 2)
                {
                    Console.WriteLine($"Result: {first_operand - second_operand}");
                }
                else if (choise == 3)
                {
                    Console.WriteLine($"Result: {first_operand * second_operand}");
                }
                else if (choise == 4)
                {
                    Console.WriteLine($"Result: {first_operand / second_operand}");
                }
                else
                {
                    Console.WriteLine("Thank you for using the Simple Calculator!");
                }
                Console.Write("Perform another operation? (yes/no): ");
                string answer = Console.ReadLine();
                flag = ((answer == "yes") ? true : false);
            }
            Console.WriteLine("Thank you for using the Simple Calculator!");

        }
    }
}