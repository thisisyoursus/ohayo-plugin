using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddCandy;
using Door;using Exiled.Events.Handlers;
using OhayoPlugin;
using Player = Exiled.Events.Handlers.Player;
using Round = Exiled.API.Features.Round;
using Server = Exiled.Events.Handlers.Server;
using Scp079 = Exiled.Events.Handlers.Scp079;
using Scp096 = Exiled.Events.Handlers.Scp096;
using Map = Exiled.Events.Handlers.Map;

namespace OhayoPluginEventsHandler
{

    public static class EventsHandler
    {
        private static AddCandy.AddCandy _candy = new AddCandy.AddCandy();
        private static UnbreakableDoor _door = new UnbreakableDoor();
        private static Disablebullethole _disablebullethole = new Disablebullethole();
        public static void RegisterEvents()
        {
         Player.Spawned += _candy.OnSpawned;
         Player.DamagingDoor += _door.OnDamaging;
         Map.PlacingBulletHole += _disablebullethole.OnPlacing;
        }

        public static void UnregisterEvents()
        {
            Player.Spawned -= _candy.OnSpawned;
            Player.DamagingDoor -= _door.OnDamaging;
            Map.PlacingBulletHole -= _disablebullethole.OnPlacing;
        }
    }


}

