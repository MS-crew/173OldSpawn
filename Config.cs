﻿using Exiled.API.Interfaces;

namespace _173OldSpawn
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public int change { get; set; } = 50;
    }
}
