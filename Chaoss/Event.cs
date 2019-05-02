using System.Collections.Generic;
using Smod2;
using Smod2.EventHandlers;
using Smod2.Events;
using scp4aiur;
using Smod2.EventSystem.Events;

namespace Chaoss
{
    partial class Event : IEventHandlerTeamRespawn
    {
        private Chaoss plugin;

        public Event(Chaoss plugin)
        {
            this.plugin = plugin;
        }



        public void OnTeamRespawn(TeamRespawnEvent ev)
        {
            if (ev.SpawnChaos)
            {
             PluginManager.Manager.Server.Map.AnnounceCustomMessage("attention all facility personnel, Unauthorized personnel has been detected on the surface");
            }
        }
    }
}
