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

        public static void WriteColored(string text, ConsoleColor color = ConsoleColor.Gray)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static async Task WriteLineColoredAsync(string message, ConsoleColor color = ConsoleColor.Gray)
        {
            var previousColor = Console.ForegroundColor;
            await Console.Out.WriteLineAsync(message);
            Console.ForegroundColor = previousColor;
        }

        public static async Task WriteColoredAsync(string message, ConsoleColor color = ConsoleColor.Gray)
        {
            var previousColor = Console.ForegroundColor;
            await Console.Out.WriteAsync(message);
            Console.ForegroundColor = previousColor;
        }
    }
}
