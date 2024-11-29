using System;
using Exiled.API.Features;
using P = Exiled.Events.Handlers.Player;

namespace _173OldSpawn
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }
        public override string Author => "ZurnaSever";
        public override string Name => "173OldSpawn";
        public override string Prefix => "173OldSpawn";
        public override Version RequiredExiledVersion { get; } = new Version(9, 0, 0);
        public override Version Version { get; } = new Version(1, 2, 0);

        private EventHandlers eventHandler;
        public override void OnEnabled()
        {
            Instance = this;
            eventHandler = new EventHandlers(this);
            P.Spawning += eventHandler.OldSpawn;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            P.Spawning -= eventHandler.OldSpawn;
            eventHandler = null;
            Instance = null;
            base.OnDisabled();
        }      
    }
}
