namespace PredefinedCassie.Command
{
    using CommandSystem;
    using RemoteAdmin;
    using System;
    using Player = Exiled.API.Features.Player;

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class CassieParentCommand : ParentCommand
    {
        public CassieParentCommand() => LoadGeneratedCommands();
        public override string Command { get; } = "PredefinedCassie";

        public override string[] Aliases { get; } = { "PC" };

        public override string Description { get; } = "Executes an Predefined Cassie Command";

        public override void LoadGeneratedCommands()
        {
            RegisterCommand(new Cassie1());
            RegisterCommand(new Cassie2());
            RegisterCommand(new Cassie3());
            RegisterCommand(new Cassie4());
            RegisterCommand(new Cassie5());
            RegisterCommand(new Cassie6());
            RegisterCommand(new Cassie7());
            RegisterCommand(new Cassie8());
            RegisterCommand(new Cassie9());
            RegisterCommand(new Cassie10());
        }

        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get((sender as PlayerCommandSender).SenderId);

            response = "<color=red>Error</color> Please enter a valid command";
            return false;
        }
    }
}
