using Smod2;
using Smod2.Attributes;

namespace Chaoss
{
    [PluginDetails(
        author = "Albertinchu",
        name = "Chaoss",
        description = "attention all facility personnel the chaos insurgency has broken the security of the facility ",
        id = "albertinchu.chaoss",
        version = "1.0.0",
        SmodMajor = 3,
        SmodMinor = 0,
        SmodRevision = 0
        )]
    public class Chaoss : Plugin
    {

        public override void OnDisable()
        {
            this.Info("Chaoss - Desactivado");
        }

        public override void OnEnable()
        {
            Info("Chaoss - Activado.");
        }

        public override void Register()
        {
           
            
            this.AddEventHandlers(new Event(this),Smod2.Events.Priority.Lowest);

        }
        public void RefreshConfig()
        {


        }
    }

}


