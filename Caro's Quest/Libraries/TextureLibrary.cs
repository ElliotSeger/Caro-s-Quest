using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace Caro_s_Quest.Libraries
{
    static class TextureLibrary
    {
        static Dictionary<string, Texture2D> textures;

        public static Texture2D GetTexture(string key)
        {
            return textures[key];
        }

        public static void LoadTextures(ContentManager contentManager)
        {
            textures = new Dictionary<string, Texture2D>
            {
                ["Player"] = contentManager.Load<Texture2D>("red"), 
                ["Inventory"] = contentManager.Load<Texture2D>("inventory"),
                ["HealthPotion"] = contentManager.Load<Texture2D>("potion"),
                ["Sword"] = contentManager.Load<Texture2D>("sword"),
            };
        }
    }
}
