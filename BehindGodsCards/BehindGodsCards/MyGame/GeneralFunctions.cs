using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BehindGodsCards.MyGame
{
    public static class GeneralFunctions
    {
        public static int ScreenWidth;
        public static int ScreenHeight;

        public static bool InMenu;
        public static bool InGame;

        public static int MouseX;
        public static int MouseY;
        public static ButtonState MouseLeftClicked;
        public static ButtonState MouseLRightClicked;

        public static double RelativeX;
        public static double RelativeSpeed;
        public static double RelativeMaxLeft;
        public static double RelativeMaxRight;

        public static void Init()
        {
            InMenu = false;
            InGame = false;
            RelativeSpeed = 100;
        }

        public static void UpdateMouse()
        {
            MouseState mouse = Mouse.GetState();
            MouseX = mouse.Position.X;
            MouseY = mouse.Position.Y;
            MouseLeftClicked = mouse.LeftButton;
            MouseLRightClicked = mouse.RightButton;
        }
    }
}
