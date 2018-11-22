using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Caro_s_Quest.Libraries;

namespace Caro_s_Quest.Objects.Creatures.Player
{
    class Inventory
    {
        Item[] items;
        Texture2D texture;
        Rectangle rectangle;
        Rectangle[] itemSlots;
        bool showInventory;

        public Inventory()
        {
            items = new Item[36];
            itemSlots = new Rectangle[36];

            Point slotSize = new Point(50, 50);
            for(int y = 0; y < 3; ++y)
            {
                for(int x = 0; x < 12; ++x)
                {
                    itemSlots[y * 12 + x].Location = new Point(slotSize.X * x, slotSize.Y * y);
                    itemSlots[y * 12 + x].Size = slotSize;
                }
            }
            rectangle = new Rectangle(150, 100, 450, 300);
            showInventory = false;
        }

        public bool AddItem(Item item)
        {
            for(int i = 0; i < items.Length; ++i)
            {
                if(items[i] != null)
                {
                    continue;
                }
                items[i] = item;
                return true;
            }
            return false;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(!showInventory)
            {
                return;
            }

            for(int i = 0; i < items.Length; ++i)
            {
                if(items[i] == null)
                {
                    continue;
                }
                spriteBatch.Draw(items[i].texture, itemSlots[i], Color.White);
            }
        }

        public void Toggle()
        {
            showInventory = !showInventory;
        }
    }
}
