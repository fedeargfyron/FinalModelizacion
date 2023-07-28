namespace FinalFede.Controllers.Contracts.Response
{
    public record BaseQueueMetricResponse
    {
        public string TimeUnit { get; set; } = string.Empty;
        public double ArriveValue { get; set; }
        public double ServiceValue { get; set; }
        public double Ls { get; set; }
        public double Lq { get; set; }
        public double Ws { get; set; }
        public double Wq { get; set; }
        public double P { get; set; }
        public double P0 { get; set; }
        public double Pn { get; set; }
    }
}
