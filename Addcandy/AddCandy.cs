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
    public class AddCandy : Addcandy.Plugin
    {
        private Config _Config =new Config();


        public void OnSpawned(SpawnedEventArgs ev)
        {
            if (_Config.IsAllowAddCandy)
            {


                Exiled.API.Features.Items.Scp330 scp330 =
                    (Exiled.API.Features.Items.Scp330)Item.Create(ItemType.SCP330, (Exiled.API.Features.Player)null);
                Random random = new Random();
                CandyKindID[] array = ((IEnumerable<CandyKindID>)(Enum.GetValues(typeof(CandyKindID)) as CandyKindID[]))
                    .Where<CandyKindID>((Func<CandyKindID, bool>)(c => c != CandyKindID.None && c != CandyKindID.Pink))
                    .ToArray<CandyKindID>();
                for (int index = 0; index < 6; ++index)
                {
                    CandyKindID candyKindId = array[random.Next(array.Length)];
                    scp330.AddCandy(candyKindId);
                }

                if (ev.Player.Role.Side == null && ev.Player.Role != RoleTypeId.Spectator)
                {
                    return;
                }
                else
                {
                    ev.Player.AddItem((Item)scp330);
                }
            }

        }
    }
}
