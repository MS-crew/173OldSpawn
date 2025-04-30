using UnityEngine;
using Exiled.API.Interfaces;
using Utf8Json.Internal.DoubleConversion;
using Exiled.API.Enums;

namespace _173OldSpawn
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public int change { get; set; } = 50;
        public Vector3 offset { get; set; } = new Vector3(17.126f, 13.0f, 7.661f);
        public RoomType Room { get; set; } = RoomType.Lcz173;
    }
}
