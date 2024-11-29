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
            if (ev.Player.Role.Type == PlayerRoles.RoleTypeId.Scp173)
                if (Random.value <= Plugin.Instance.Config.change/100f)
                    ev.Position = Room.Get(RoomType.Lcz173).WorldPosition(new Vector3(17.126f, 13.0f, 7.661f));
            
        }
    }
}
