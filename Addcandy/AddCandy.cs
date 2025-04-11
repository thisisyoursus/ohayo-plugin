using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features.Items;
using Exiled.API.Features.Roles;
using Exiled.Events.EventArgs.Player;
using InventorySystem.Items.Usables.Scp330;
using AddcandyConfig;
using AddcandyEventsHandler;
using PlayerRoles;
using PlayerRoles.RoleAssign;

namespace AddCandy
{
    public class AddCandy
    {
        private Config _Config = new Config();

        public void OnSpawned(SpawnedEventArgs ev)
        {
            if (_Config.IsAllowAddCandy && ev.Player != null && ev.Player.Role != null)
            {
                if (ev.Player.Role.Side == null && ev.Player.Role.Type != RoleTypeId.Spectator)
                {
                    return;
                }

                Exiled.API.Features.Items.Scp330 scp330 = (Exiled.API.Features.Items.Scp330)Item.Create(ItemType.SCP330, ev.Player);
                if (scp330 == null)
                {
                    Exiled.API.Features.Log.Error("Failed to create SCP-330 item.");
                    return;
                }

                Random random = new Random();
                CandyKindID[] array = Enum.GetValues(typeof(CandyKindID)) as CandyKindID[];
                array = Array.FindAll(array, c => c != CandyKindID.None && c != CandyKindID.Pink);

                for (int index = 0; index < 6; index++)
                {
                    CandyKindID candyKindId = array[random.Next(array.Length)];
                    scp330.AddCandy(candyKindId);
                }

                ev.Player.AddItem((Item)scp330); ;
            }
        }
    }
}
