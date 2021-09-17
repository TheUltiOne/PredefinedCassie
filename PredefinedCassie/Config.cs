<<<<<<< master
﻿namespace PredefinedCassie
{
    using Exiled.API.Interfaces;
    using System.Collections.Generic;
    using System.ComponentModel;

    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("If you set it to false, all predefined cassies will not have the starting and ending sound and noise between them")]
        public bool AreCassiesNoisy { get; set; } = true;

        public Dictionary<string, string> PredefiniedCassies { get; set; } = new Dictionary<string, string>
        {
            { "mtf", "yes" },
            { "chaos", "no" }
        };
    }
=======
﻿namespace PredefinedCassie
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
        public string Cassie2 { get; private set; }
        public string Cassie3 { get; private set; }
        public string Cassie4 { get; private set; }
        public string Cassie5 { get; private set; }
        public string Cassie6 { get; private set; }
        public string Cassie7 { get; private set; }
        public string Cassie8 { get; private set; }
        public string Cassie9 { get; private set; }
        public string Cassie10 { get; private set; }
    }
>>>>>>> master
}