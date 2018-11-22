using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Caro_s_Quest.Libraries;

namespace Caro_s_Quest.Objects
{
    abstract class Item : GameObject
    {
        public Texture2D texture;
        public Rectangle rectangle;

        public Item()
        {
            
        }
    }
}
