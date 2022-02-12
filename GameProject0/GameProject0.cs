using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameProject0
{
    public class GameProject0 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private SunSprite whiteMoonSprite;
        private CloudSprite cloud;
        private BackgroundSprite background;
        private SaturnSprite star;
        private List<ExplosionSprite> explosions;
        private InputManager inputManager;
        private SpriteFont spriteFont;

        public GameProject0()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            whiteMoonSprite = new SunSprite();
            cloud = new CloudSprite();
            background = new BackgroundSprite();
            star = new SaturnSprite();
            explosions = new List<ExplosionSprite>();
            inputManager = new InputManager();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            whiteMoonSprite.LoadContent(Content);
            cloud.LoadContent(Content);
            background.LoadContent(Content);
            star.LoadContent(Content);

            foreach (var expl in explosions)
            {
                expl.LoadContent(Content);
            }

            spriteFont = Content.Load<SpriteFont>("bangers");
        }

        protected override void Update(GameTime gameTime)
        {
            inputManager.Update(gameTime, Content, explosions);

            if (inputManager.ExitGame)
            {
                Exit();
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            whiteMoonSprite.Draw(gameTime, _spriteBatch);
            cloud.Draw(gameTime, _spriteBatch);
            background.Draw(gameTime, _spriteBatch);
            star.Draw(gameTime, _spriteBatch);

            foreach (var expl in explosions)
            {
                if (expl.AnimationFrame < 65)
                {
                    expl.Draw(gameTime, _spriteBatch);
                }
            }

            _spriteBatch.DrawString(spriteFont, "Click to cause", new Vector2(100, 100), Color.Indigo);
            _spriteBatch.DrawString(spriteFont, "an explosion", new Vector2(100, 140), Color.Indigo);

            _spriteBatch.DrawString(spriteFont, "Press Escape to Exit", new Vector2(300, 435), Color.Red);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
