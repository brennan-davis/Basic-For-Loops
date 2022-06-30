bool continueLoop = true;
while(continueLoop)
{
    int sum = 0;

    Console.WriteLine("Enter a whole number greater than 1:");

    bool inputIsInt = int.TryParse(Console.ReadLine(), out int num);

    while (!inputIsInt) inputIsInt = int.TryParse(Console.ReadLine(), out num);

    for (int i = 0; i <= num; i++) sum += i;

    Console.WriteLine(sum);

    Console.WriteLine("\nWould you like to continue? (y)");
    continueLoop = Console.ReadKey().Key == ConsoleKey.Y;
    Console.WriteLine("\n");
}