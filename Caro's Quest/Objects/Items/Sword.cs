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
    class Sword : Item
    {
        public Sword(Point position)
        {
            texture = TextureLibrary.GetTexture("Sword");
            rectangle = new Rectangle(position, new Point(100, 10));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
