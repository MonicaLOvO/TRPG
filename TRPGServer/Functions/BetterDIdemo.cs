using TRPGServer.Functions.Interface;

namespace TRPGServer.Functions
{
    public class BetterDIdemo : IDIdemo
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public BetterDIdemo()
        {
            Value1 = 3;
            Value2 = 80;
        }
    }
}
