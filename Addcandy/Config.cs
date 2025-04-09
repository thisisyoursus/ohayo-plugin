using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using Exiled.API.Interfaces;
using Exiled.CreditTags;

namespace AddcandyConfig
{
    public class Config : IConfig
    {
        public bool IsEnabled { get ; set ; } =true;
        public bool Debug { get ; set; }=false;

        [Description("Enable add Candy or Disable ")]
        public bool IsAllowAddCandy { get; set; } = true;

    }
}
