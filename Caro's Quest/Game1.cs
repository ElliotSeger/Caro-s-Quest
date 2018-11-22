using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Caro_s_Quest.Objects;
using Caro_s_Quest.Objects.Creatures;
using Caro_s_Quest.Libraries;
using Caro_s_Quest.Objects.Creatures.Player;
using Caro_s_Quest.Objects.Items;

namespace Caro_s_Quest
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static List<GameObject> objects;
        string title;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            IsMouseVisible = true;

            title = Window.Title;

            //TargetElapsedTime = System.TimeSpan.Zero;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

            objects = new List<GameObject>
            {
                new HealthPotion(new Point(500, 100)),
                new HealthPotion(new Point(400, 100)),
                new HealthPotion(new Point(300, 100)),
                new HealthPotion(new Point(200, 100)),
                new HealthPotion(new Point(100, 100)),
                new HealthPotion(new Point(500, 100)),
                new HealthPotion(new Point(400, 100)),
                new HealthPotion(new Point(300, 100)),
                new HealthPotion(new Point(200, 100)),
                new HealthPotion(new Point(100, 100)),
                new HealthPotion(new Point(500, 100)),
                new HealthPotion(new Point(400, 100)),
                new HealthPotion(new Point(300, 100)),
                new HealthPotion(new Point(200, 100)),
                new HealthPotion(new Point(100, 100)),
                new HealthPotion(new Point(500, 100)),
                new HealthPotion(new Point(400, 100)),
                new HealthPotion(new Point(300, 100)),
                new HealthPotion(new Point(200, 100)),
                new HealthPotion(new Point(100, 100)),
                new HealthPotion(new Point(500, 100)),
                new HealthPotion(new Point(400, 100)),
                new HealthPotion(new Point(300, 100)),
                new HealthPotion(new Point(200, 100)),
                new HealthPotion(new Point(100, 100)),
                new HealthPotion(new Point(500, 100)),
                new HealthPotion(new Point(400, 100)),
                new HealthPotion(new Point(300, 100)),
                new HealthPotion(new Point(200, 100)),
                new HealthPotion(new Point(100, 100)),
                new HealthPotion(new Point(500, 100)),
                new HealthPotion(new Point(400, 100)),
                new HealthPotion(new Point(300, 100)),
                new HealthPotion(new Point(200, 100)),
                new HealthPotion(new Point(100, 100)),
                new HealthPotion(new Point(500, 100)),
                new HealthPotion(new Point(400, 100)),
                new HealthPotion(new Point(300, 100)),
                new HealthPotion(new Point(200, 100)),
                new HealthPotion(new Point(100, 100)),
                new Sword(new Point(350, 222)),
                new Player(),
            };
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            TextureLibrary.LoadTextures(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            for (int i = 0; i < objects.Count; ++i)
            {
                objects[i].Update(gameTime);
            }

            if (gameTime.ElapsedGameTime.TotalSeconds != 0)
            {
                Window.Title = title + " FPS: " + (1f / gameTime.ElapsedGameTime.TotalSeconds).ToString();
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            foreach (GameObject gameObject in objects)
            {
                gameObject.Draw(gameTime, spriteBatch);
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
