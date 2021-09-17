﻿namespace PredefinedCassie.Command
{
    using CommandSystem;
    using Exiled.API.Features;
    using Exiled.Permissions.Extensions;
    using System;
    using static Plugin;

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class Cassie9 : ICommand
    {
        public string Command { get; } = "9";

        public string[] Aliases { get; }

        public string Description { get; } = "Executes an Predefined Cassie Command";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!sender.CheckPermission("pc.cassie"))
            {
                response = "You can't execute this command. Missing permission pc.cassie";
                return false;
            }
            Cassie.Message(Instance.Config.Cassie9, false, Instance.Config.AreCassiesNoisy);
            response = "Executed Predefined Cassie";
            return true;
        }
    }
}
