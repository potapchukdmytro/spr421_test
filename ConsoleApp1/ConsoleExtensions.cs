namespace ConsoleApp1
{
    public static class ConsoleExtensions
    {
        public static void WriteLineColored(string text, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
