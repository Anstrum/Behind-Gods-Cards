using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using BehindGodsCards.MyGame;

namespace BehindGodsCards.Menu
{
    class MenuButtons
    {
        public Texture2D Sprite1;
        public Texture2D Sprite2;
        public Texture2D Sprite3;
        public Vector2 ButtonsPosition;
        public bool Selected;
        public bool Clicked;
        public string Name;

        public MenuButtons(string Name1, string Name2, string Name3, ContentManager Content, string NameGive)
        {
            Sprite1 = Content.Load<Texture2D>("MenuContent\\" + Name1);
            Sprite2 = Content.Load<Texture2D>("MenuContent\\" + Name2);
            Sprite3 = Content.Load<Texture2D>("MenuContent\\" + Name3);
            Name = NameGive;
        }
        public void Draw(SpriteBatch _spritebatch)
        {
            Texture2D toDraw = Sprite1;

            if (Selected)
            {
                toDraw = Sprite2;
                if (Clicked)
                {
                    toDraw = Sprite3;
                }
            }
            _spritebatch.Draw(toDraw, ButtonsPosition, Color.White);

        }

        public void Update()
        {

            if (GeneralFunctions.MouseX >= ButtonsPosition.X && GeneralFunctions.MouseX <= ButtonsPosition.X + Sprite1.Width && GeneralFunctions.MouseY >= ButtonsPosition.Y && GeneralFunctions.MouseY <= ButtonsPosition.Y + Sprite1.Height)
            {
                Selected = true;
            }
            else
            {
                Selected = false;
            }
            if (Selected == true && GeneralFunctions.MouseLeftClicked == ButtonState.Pressed)
            {
                Clicked = true;
            }
            else
            {
                Clicked = false;
            }
        }
    }
}
