using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddCandy;
using Exiled.Events.Handlers;
using Addcandy;
using Player = Exiled.Events.Handlers.Player;
using Round = Exiled.API.Features.Round;
using Server = Exiled.Events.Handlers.Server;
using Map = Exiled.Events.Handlers.Map;

namespace AddcandyEventsHandler
{

    public static class EventsHandler
    {
        private static AddCandy.AddCandy _candy = new AddCandy.AddCandy();
        public static void RegisterEvents()
        {
         Player.Spawned += _candy.OnSpawned;
        }

        public static void UnregisterEvents()
        {
            Player.Spawned -= _candy.OnSpawned;
        }
    }


}

