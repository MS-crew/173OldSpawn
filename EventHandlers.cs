using UnityEngine;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace _173OldSpawn
{
    public class EventHandlers
    {
        private readonly Plugin plugin;

        public EventHandlers(Plugin plugin) => this.plugin = plugin;

        public void OldSpawn(SpawningEventArgs ev)
        {
            if (ev.Player.Role.Type != PlayerRoles.RoleTypeId.Scp173)
                return;

            if (Random.Range(0, 100) => plugin.Config.change)
                return;

            ev.Position = Room.Get(plugin.Config.Room).WorldPosition(plugin.Config.offset);    
        }
    }
}
