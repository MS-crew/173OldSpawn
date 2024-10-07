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
            {
                var globalCords = GetGlobalCords(new Vector3(17.126f, 13.0f, 7.661f), Room.Get(RoomType.Lcz173));
                ev.Position = globalCords;
            }
        }
        private static Vector3 GetGlobalCords(Vector3 localCords, Room room)
        {
            var rotation = room.Rotation;
            if (Math.Abs(rotation.eulerAngles.y - 0.0f) < 1.0)
                return new Vector3(room.Position.x + localCords.x, room.Position.y + localCords.y, room.Position.z + localCords.z);
            if (Math.Abs(rotation.eulerAngles.y - 90f) < 1.0)
                return new Vector3(room.Position.x + localCords.z, room.Position.y + localCords.y, room.Position.z - localCords.x);

            if (Math.Abs(rotation.eulerAngles.y - 180f) < 1.0)
                return new Vector3(room.Position.x - localCords.x, room.Position.y + localCords.y, room.Position.z - localCords.z);
            return Math.Abs((rotation).eulerAngles.y - 270f) < 1.0 ? new Vector3(room.Position.x - localCords.z, room.Position.y + localCords.y, room.Position.z + localCords.x) : new Vector3(111f, 222f, 333f);
        }
    }
}
