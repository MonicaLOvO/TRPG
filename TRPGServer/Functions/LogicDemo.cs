using TRPGServer.Functions.Interface;

namespace TRPGServer.Functions
{
    public class LogicDemo : ILogicDemo
    {
        public int Variable { get; set; }
        public LogicDemo()
        {
            Console.WriteLine();
            Variable =Random.Shared.Next(minValue: 1, maxValue: 10001);
        }

    }
}
