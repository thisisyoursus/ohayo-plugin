using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Features;
using OhayoPluginConfig;
using OhayoPluginEventsHandler;
namespace Door
{
    public class UnbreakableDoor : OhayoPlugin.Plugin
    {
        private Config _Config = new Config();

        public void OnDamaging(DamagingDoorEventArgs ev)
        {
            if (_Config.UnbreakDoorTypes.Contains(ev.Door.Type))
            {
                ev.IsAllowed = false;
            }
        }
    }
}
