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
    class HealthPotion : Item
    {
        public HealthPotion(Point position)
        {
            texture = TextureLibrary.GetTexture("HealthPotion");
            rectangle = new Rectangle(position, new Point(50, 50));
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
