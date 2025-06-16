namespace TRPGServer.Model
{
    public class ResultContainer
    {
        public dynamic? data { get; set; }
        public int? total { get; set; }
        public string? message { get; set; }

        public List<string>? errorMessage { get; set; }

    }
}
