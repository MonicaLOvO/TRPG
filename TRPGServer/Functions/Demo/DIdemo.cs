namespace TRPGServer.Functions.Demo
{
    public class DIdemo : IDIdemo
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public DIdemo()
        {
            Value1 = Random.Shared.Next(minValue: 1, maxValue: 10001);
            Value2 = Random.Shared.Next(minValue: 1, maxValue: 10001);
        }
    }
}
