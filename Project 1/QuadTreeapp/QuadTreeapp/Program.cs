// See https://aka.ms/new-console-template for more information
using QuadTreeapp.models.commands;

Console.WriteLine("Hello, World!");

partial class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: QuadTreeApp <file.cmmd>");
            return;
        }

        string filePath = args[0];

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File not found: {filePath}");
            return;
        }

        CommandProcessor processor = new CommandProcessor();

        foreach (string line in File.ReadAllLines(filePath))
        {
            processor.ProcessCommand(line);
        }
    }
}
