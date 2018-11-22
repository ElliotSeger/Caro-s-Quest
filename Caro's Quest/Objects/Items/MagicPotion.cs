using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Caro_s_Quest.Libraries;


namespace Caro_s_Quest.Objects.Items
{
    class MagicPotion : Item
    {
        public MagicPotion(Point position)
        {
            texture = TextureLibrary.GetTexture("MagicPotion");
        }
    }
}
