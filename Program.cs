int slots = 0;
string[] flightNumbers = new string[slots];
while (true)
{
    Console.WriteLine("1. Add flight number to array");
    Console.WriteLine("2. Quit");
    Console.Write("Enter an option: ");

    int option = int.Parse(Console.ReadLine()!);

    switch (option)
    {
        case 1:
            slots += 1;
            Array.Resize(ref flightNumbers, slots);
            Console.Write("Enter flight No: ");
            flightNumbers[slots - 1] = (Console.ReadLine()!);
            break;
        case 2:
            foreach (string flightNumber in flightNumbers)
            {
                Console.WriteLine($"Flight Number {flightNumber}");
            }
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Enter valid option");
            break;
    }
}




