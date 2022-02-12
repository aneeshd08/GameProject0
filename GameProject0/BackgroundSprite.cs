using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace GameProject0
{
    public class BackgroundSprite
    {
        private Texture2D texture;

        /// <summary>
        /// Loads the sprite texture using the provided ContentManager
        /// </summary>
        /// <param name="content">The ContentManager to load with</param>
        public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("Background_City_Skyline_Front_02");
        }

        /// <summary>
        /// Draws the sprite using the supplied SpriteBatch
        /// </summary>
        /// <param name="gameTime">The game time</param>
        /// <param name="spriteBatch">The spritebatch to render with</param>
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            var source = new Rectangle(0, 0, 250, 170);          
            
            spriteBatch.Draw(texture, new Vector2(-100, 325), source, Color.White, 0, new Vector2(64, 64), 1.50f, SpriteEffects.None, 0);
            spriteBatch.Draw(texture, new Vector2(0, 325), source, Color.White, 0, new Vector2(64, 64), 1.50f, SpriteEffects.None, 0);
            spriteBatch.Draw(texture, new Vector2(300, 325), source, Color.White, 0, new Vector2(64, 64), 1.50f, SpriteEffects.None, 0);
            spriteBatch.Draw(texture, new Vector2(650, 325), source, Color.White, 0, new Vector2(64, 64), 1.50f, SpriteEffects.None, 0);
           
        }
    }
}
