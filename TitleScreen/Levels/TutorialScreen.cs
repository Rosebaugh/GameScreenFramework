using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TitleScreen.Content;
using TitleScreen.Levels;
using TitleScreen.Sprites;
using TitleScreen.Sprites.Items;

namespace TitleScreen.Levels
{
    public class TutorialScreen : Screen
    {
        GamePadState Previousgps;
        KeyboardState Previouskbs;

        public TutorialScreen(SpriteBatch spriteBatch, MainCharacterSprite MainCharacter)
        {
            this.spriteBatch = spriteBatch;
        }

        public override void Initialize()
        {

        }

        public override void LoadContent(ContentManager Content)
        {

        }

        public void DontLetLeave()
        {
            if (MainCharacter.Position.X + MainCharacter.pixelWidth - 35 > ScreenValues.ScreenWidth)
            {
                MainCharacter.Position.X = MainCharacter.Position.X - 50;
            }
            else if (MainCharacter.Position.X + 15 < 0)
            {
                MainCharacter.Position.X = MainCharacter.Position.X + 15;
            }
        }

        public override void Update(GameTime gameTime, KeyboardState KBstate, GamePadState GPstate)
        {

        }

        public override void Draw(GameTime gameTime)
        {
            if (ScreenValues.State != ScreenValues.GameState.PauseMenu && ScreenValues.State != ScreenValues.GameState.DeathScreen)
            {
                MainCharacter.Update(gameTime);
            }
        }
    }
}
