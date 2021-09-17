namespace PredefinedCassie
{
    using Exiled.API.Interfaces;
    using System.ComponentModel;

    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("If you set it to false, all predefined cassies will not have the starting and ending sound and noise between them")]
        public bool AreCassiesNoisy { get; private set; } = true;
        [Description("Example")]
        public string Cassie1 { get; private set; } = "Containment Breach Detected";
        public string Cassie2 { get; }
        public string Cassie3 { get; }
        public string Cassie4 { get; }
        public string Cassie5 { get; }
        public string Cassie6 { get; }
        public string Cassie7 { get; }
        public string Cassie8 { get; }
        public string Cassie9 { get; }
        public string Cassie10 { get; }
    }
}