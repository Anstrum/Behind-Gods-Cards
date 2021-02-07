using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using BehindGodsCards.MyGame;

namespace BehindGodsCards.Menu
{
    public class MainMenu
    {
        public int WindowHeight;
        public int WindowWidth;
        public GraphicsDeviceManager _graphics;
        public SpriteBatch _spritebatch;
        public ContentManager Content;

        protected Vector2 BackGroundPosition;
        protected Vector2 TitrePosition;
        protected Vector2 YnovLogoPosition;

        protected Texture2D BackGroundTexture;
        protected Texture2D TitreTexture;
        protected Texture2D YnovLogoTexture;

        List<MenuButtons> Boutons = new List<MenuButtons>();

        public MainMenu(GraphicsDeviceManager graphics, SpriteBatch spritebatch, ContentManager content)
        {
            _graphics = graphics;
            _spritebatch = spritebatch;
            Content = content;

            WindowHeight = GeneralFunctions.ScreenHeight;
            WindowWidth = GeneralFunctions.ScreenWidth;
            Content.RootDirectory = "Content";
        }

        public void Load()
        {

            BackGroundTexture = Content.Load<Texture2D>("MenuContent\\" + "bgBGC");
            TitreTexture = Content.Load<Texture2D>("MenuContent\\" + "titremenu");
            YnovLogoTexture = Content.Load<Texture2D>("MenuContent\\" + "YnovLogo");

            Boutons.Add(new MenuButtons("play_sprite_1", "play_sprite_2", "play_sprite_3", Content, "Play"));
            Boutons.Add(new MenuButtons("option_sprite_1", "option_sprite_2", "option_sprite_3", Content, "Options"));
            Boutons.Add(new MenuButtons("credits_sprite_1", "credits_sprite_2", "credits_sprite_3", Content, "Credits"));
            Boutons.Add(new MenuButtons("quit_sprite_1", "quit_sprite_2", "quit_sprite_3", Content, "Quit"));


            int ButtonSpace = (WindowHeight - 80 - 4 * Boutons[1].Sprite1.Height) / (Boutons.Count + 1);
            
            for (int i = 0; i < Boutons.Count; i++)
            {
                Boutons[i].ButtonsPosition.X = (WindowWidth - Boutons[i].Sprite1.Width) / 2;
                Boutons[i].ButtonsPosition.Y = WindowHeight / 4 + (i + 1) * ButtonSpace + (i * Boutons[i].Sprite1.Height);
            }


            BackGroundPosition = new Vector2(0, 0);
            TitrePosition = new Vector2((WindowWidth - TitreTexture.Width) / 2, WindowHeight / 14);
            YnovLogoPosition = new Vector2(-10, WindowHeight - YnovLogoTexture.Height + 10);
        }
        public string Update()
        {
            string ToReturn = "";
            foreach (MenuButtons bouton in Boutons)
            {
                if (bouton.Clicked == true && GeneralFunctions.MouseLeftClicked == ButtonState.Released)
                {
                    switch (bouton.Name)
                    {
                        case "Play":
                            foreach (MenuButtons btn in Boutons)
                            {
                                btn.Selected = false;
                                btn.Clicked = false;
                            }
                            ToReturn = "Play";
                            break;
                        case "Options":
                            foreach (MenuButtons btn in Boutons)
                            {
                                btn.Selected = false;
                                btn.Clicked = false;
                            }
                            ToReturn = "Options";
                            break;
                        case "Credits":
                            foreach (MenuButtons btn in Boutons)
                            {
                                btn.Selected = false;
                                btn.Clicked = false;
                            }
                            ToReturn = "Credits";
                            break;
                        case "Quit":
                            ToReturn = "Quit";
                            break;
                    }
                }
                bouton.Update();
            }
            return ToReturn;
        }
        public void Draw()
        {


            _spritebatch.Draw(BackGroundTexture, BackGroundPosition, Color.White);
            _spritebatch.Draw(TitreTexture, TitrePosition, Color.White);
            _spritebatch.Draw(YnovLogoTexture, YnovLogoPosition, Color.White);


            foreach (MenuButtons Button in Boutons)
            {
                Button.Draw(_spritebatch);
            }




        }
    }
}