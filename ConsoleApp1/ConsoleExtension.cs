namespace ConsoleApp1
{
    public class ConsoleExtension
    {
        public static async Task WriteLineColoredAsync(string message, ConsoleColor color = ConsoleColor.Gray)
        {
            var previousColor = Console.ForegroundColor;
            await Console.Out.WriteLineAsync(message);
            Console.ForegroundColor = previousColor;
        }
    }
}
