using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameProject0
{
    public class SaturnSprite
    {
        private Texture2D texture;

        /// <summary>
        /// Loads the sprite texture using the provided ContentManager
        /// </summary>
        /// <param name="content">The ContentManager to load with</param>
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("Saturn");
        }

        /// <summary>
        /// Draws the sprite using the supplied SpriteBatch
        /// </summary>
        /// <param name="gameTime">The game time</param>
        /// <param name="spriteBatch">The spritebatch to render with</param>
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Vector2 position = new Vector2(700, 20);
            var source = new Rectangle(0, 0, 16, 16);
            spriteBatch.Draw(texture, position, source, Color.White, 0, new Vector2(0, 0), 3f, SpriteEffects.None, 0);
        }
    }
}
