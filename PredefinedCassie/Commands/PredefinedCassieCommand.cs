namespace PredefinedCassie.Command
{
    using CommandSystem;
    using Exiled.API.Features;
    using RemoteAdmin;
    using System;

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class PredefinedCassieCommand : ICommand
    {
        public string Command { get; } = "predefinedcassie";

        public string[] Aliases { get; } = { "pc" };

        public string Description { get; } = "Executes an Predefined Cassie Command";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get((sender as PlayerCommandSender).ReferenceHub);

            if (arguments.Count == 0 || arguments.At(0) == "list")
            {
                string cassies = "";
                foreach (KeyValuePair<string, string> kvp in Plugin.Singleton.Config.PredefiniedCassies)
                {
                    cassies += $"{kvp.Key}: {kvp.Value}\n";
                }

                response = $"Available cassies: \n{cassies}";
                return false;
            }

            string cassie = arguments.At(0);

            if (!Plugin.Singleton.Config.PredefiniedCassies.ContainsKey(cassie))
            {
                response = $"The predefined cassie <b>{cassie}</b> isn't valid";

                return false;
            }

            Cassie.Message(Plugin.Singleton.Config.PredefiniedCassies[cassie], false, Plugin.Singleton.Config.AreCassiesNoisy);

            response = "Cassie sent";
            return true;
        }
    }
}
