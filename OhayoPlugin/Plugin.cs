using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using OhayoPluginConfig;
using OhayoPluginEventsHandler;

namespace OhayoPlugin
{
    public class Plugin :Plugin<Config>
    {

        public override string Name => "OhayoPlugin";
        public override string Author => "hayabusa255";
        public override Version Version => new Version(1, 0, 0);
        public override void OnEnabled()
        {
            base.OnEnabled();
            EventsHandler.RegisterEvents();

        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            EventsHandler.UnregisterEvents();
        }
        
    }
}
