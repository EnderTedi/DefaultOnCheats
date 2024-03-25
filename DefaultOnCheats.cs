using StardewModdingAPI;
using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultOnCheats
{
    public class DefaultOnCheats : Mod
    {
        public override void Entry(IModHelper helper)
        {
            Program.enableCheats = true;
        }
    }
}
