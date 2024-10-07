using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;
using UnityEngine;

namespace _173OldSpawn
{
    public class EventHandlers
    {
        private readonly Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public void OldSpawn(SpawningEventArgs ev)
        {
            if (ev.Player.Role.Type == PlayerRoles.RoleTypeId.Scp173)
                ev.Position = Room.Get(RoomType.Lcz173).LocalPosition(new Vector3(17.126f, 13.0f, 7.661f));
        }
    }
}
