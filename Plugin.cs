using System;
using Exiled.API.Features;
using Scp173 = Exiled.Events.Handlers.Player;

namespace _173OldSpawn
{
    public class Plugin : Plugin<Config>
    {
        private EventHandlers eventHandler;

        public override string Author => "ZurnaSever";

        public override string Name => "173OldSpawn";

        public override string Prefix => "173OldSpawn"; 

        public override Version Version { get; } = new Version(1, 2, 1);

        public override Version RequiredExiledVersion { get; } = new Version(9, 0, 0);
        
        public override void OnEnabled()
        {
            eventHandler = new EventHandlers(this);

            Scp173.Spawning += eventHandler.OldSpawn; 

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Scp173.Spawning -= eventHandler.OldSpawn;

            eventHandler = null;
            base.OnDisabled();
        }      
    }
}
