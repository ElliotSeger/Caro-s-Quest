using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Caro_s_Quest.Libraries;

namespace Caro_s_Quest.Objects.Creatures.Player
{
    class Player : Creature
    {
        Texture2D texture;
        Rectangle rectangle;
        Vector2 moveDir;
        float speed;
        Inventory inventory;

        public Player()
        {
            texture = TextureLibrary.GetTexture("Player");
            speed = 600;
            rectangle = texture.Bounds;
            inventory = new Inventory();
        }

        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            KeyboardState keyboardState = Keyboard.GetState();
            moveDir = new Vector2();
            if (keyboardState.IsKeyDown(Keys.D))
            {
                moveDir.X = 1;
            }
            if (keyboardState.IsKeyDown(Keys.A))
            {
                moveDir.X = -1;
            }
            if (keyboardState.IsKeyDown(Keys.W))
            {
                moveDir.Y = -1;
            }
            if (keyboardState.IsKeyDown(Keys.S))
            {
                moveDir.Y = 1;
            }
            if (moveDir != Vector2.Zero)
            {
                moveDir.Normalize();
                rectangle.Location += (moveDir * speed * deltaTime).ToPoint();
            }

            if(keyboardState.IsKeyDown(Keys.I))
            {
                inventory.Toggle();
            }

            for(int i = 0; i < Game1.objects.Count; ++i)
            {
                Item item = Game1.objects[i] as Item;
                if(item == null)
                {
                    continue;
                }
                if(item.rectangle.Intersects(rectangle))
                {
                    if(inventory.AddItem(item))
                    {
                        Game1.objects.Remove(item);
                    }
                }
            }
        }

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
            inventory.Draw(spriteBatch);
        }
    }
}
