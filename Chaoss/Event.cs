
using Smod2;
using Smod2.EventHandlers;
using Smod2.Events;
using Smod2.EventSystem.Events;
using Smod2.API;
namespace Chaoss
{
    partial class Event : IEventHandlerTeamRespawn, IEventHandlerSetRole
    {
        private Chaoss plugin;
        private bool contadorcaos = false;

        public Event(Chaoss plugin)
        {
            this.plugin = plugin;
        }

        public void OnSetRole(PlayerSetRoleEvent ev)
        {
            if(PluginManager.Manager.Server.Round.Duration < 20)
            {
                foreach (Player player in PluginManager.Manager.Server.GetPlayers())
                {
                    if((player.TeamRole.Role == Role.CHAOS_INSURGENCY)&&(contadorcaos == false))
                    {
                        contadorcaos = true;
                        PluginManager.Manager.Server.Map.AnnounceCustomMessage("attention all facility personnel, Unauthorized personnel has been detected on the surface");

                    }

                }
            }
        }

        public void OnTeamRespawn(TeamRespawnEvent ev)
        {
            if((PluginManager.Manager.Server.Round.Duration > 60 )&&(ev.SpawnChaos))
            {
             PluginManager.Manager.Server.Map.AnnounceCustomMessage("attention all facility personnel, Unauthorized personnel has been detected on the surface");
            }
         
        }
    }
}
