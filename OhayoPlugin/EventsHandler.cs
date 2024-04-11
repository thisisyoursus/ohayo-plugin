using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddCandy;
using Door;

namespace OhayoPluginEventsHandler
{

    public static class EventsHandler
    {
        private static AddCandy.AddCandy _candy = new AddCandy.AddCandy();
        private static UnbreakableDoor _door = new UnbreakableDoor();

        public static void RegisterEvents()
        {
            Exiled.Events.Handlers.Player.Spawned += _candy.OnSpawned;
            Exiled.Events.Handlers.Player.DamagingDoor += _door.OnDamaging;
        }

        public static void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.Spawned -= _candy.OnSpawned;
            Exiled.Events.Handlers.Player.DamagingDoor -= _door.OnDamaging;
        }
    }


}
