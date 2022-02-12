using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace GameProject0
{
    public class InputManager
    {
        MouseState priorMousesState;
        MouseState currentMouseState;

        public bool ExitGame
        {
            get;
            private set;
        } = false;

        public void Update(GameTime gameTime, ContentManager content, List<ExplosionSprite> explosions)
        {

            priorMousesState = currentMouseState;
            currentMouseState = Mouse.GetState();

            if (priorMousesState.LeftButton == ButtonState.Pressed && currentMouseState.LeftButton == ButtonState.Released)
            {
                ExplosionSprite explosionSprite = new ExplosionSprite(new Vector2(currentMouseState.X, currentMouseState.Y));
                explosionSprite.LoadContent(content);
                explosions.Add(explosionSprite);
            }

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                {
                    ExitGame = true;
                }
        }
    }
}
