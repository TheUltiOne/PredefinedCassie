namespace PredefinedCassie
{
    using Exiled.API.Enums;
    using Exiled.API.Features;
    using System;

    public class Plugin : Plugin<Config>
    {
        // Singleton etc
        private static readonly Plugin Singleton = new Plugin();
        private Plugin() { }
        public static Plugin Instance => Singleton;

        // Plugin Info
        public override PluginPriority Priority { get; } = PluginPriority.Medium;
        public override string Author { get; } = "Cegla";
        public override string Name { get; } = "PredefinedCassie";
        public override string Prefix { get; } = "PredefinedCassie";
        public override Version RequiredExiledVersion { get; } = new Version(3, 0, 0);
        public override Version Version { get; } = new Version(1, 0, 0);

        public override void OnEnabled()
        {
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
        }
        private void UnregisterEvents()
        {
        }
    }
}