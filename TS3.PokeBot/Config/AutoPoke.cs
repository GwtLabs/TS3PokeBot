using System;
using System.Collections.Generic;
using System.Text;

namespace TS3.PokeBot.Config
{
    public class AutoPoke
    {
        public AutoPoke()
        {
            //if (Initialization)
                Channels = new Dictionary<ushort, AutoPokeConfig>() { { 0, new AutoPokeConfig() } };
        }
        public bool Enabled { get; set; } = true;
        public Dictionary<ushort, AutoPokeConfig> Channels = new Dictionary<ushort, AutoPokeConfig>();
    }
    public class AutoPokeConfig
    {
        public AutoPokeConfig()
        {
            //if (Initialization)
                Groups = new List<AutoPokeGroup>() { new AutoPokeGroup() };
        }
        public List<AutoPokeGroup> Groups = new List<AutoPokeGroup>();
    }
    public class AutoPokeGroup
    {
        public ushort Id { get; set; }
        public int DelayRelative { get; set; } = 0;
        public int DelayAbsolute { get; set; } = 0;
    }
}
