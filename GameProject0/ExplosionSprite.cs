using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;


namespace GameProject0
{
    public class ExplosionSprite
    {
        private Texture2D texture;

        private Vector2 position;

        private double animationTimer;

        public short AnimationFrame { get; private set; } = 0;

        public ExplosionSprite(Vector2 pos)
        {
            position = pos;
        }

        /// <summary>
        /// Loads the sprite texture using the provided ContentManager
        /// </summary>
        /// <param name="content">The ContentManager to load with</param>
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("Explosions");
        }

        /// <summary>
        /// Draws the sprite using the supplied SpriteBatch
        /// </summary>
        /// <param name="gameTime">The game time</param>
        /// <param name="spriteBatch">The spritebatch to render with</param>
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            animationTimer += gameTime.ElapsedGameTime.TotalSeconds;

            if (animationTimer > 0.1)
            {
                animationTimer -= 0.1;
                AnimationFrame++;
            }

            var source = new Rectangle(AnimationFrame * 64, 0, 64, 64);

            spriteBatch.Draw(texture, position + new Vector2(64, 64), source, Color.White, 0, new Vector2(64, 64), 2.0f, SpriteEffects.None, 0);
        }
    }
}
