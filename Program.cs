Console.WriteLine("Parrot mode started. Type something and press Enter. Type 'exit' to quit.");

while (true)
{
    Console.Write("You: ");
    var input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Parrot: You didn't type anything!");
        continue;
    }

    Console.WriteLine($"Parrot: {input}");
}
