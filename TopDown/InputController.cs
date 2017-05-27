﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace TopDown
{
    class InputController
    {
        public static Boolean IsLeftMouseButtonHeld = false;
        private static int framesPassed = 0;

        public static void ManageInputs(GameTime gameTime)
        {
            var mouse = Mouse.GetState();
            var keyboard = Keyboard.GetState();

            MouseController(mouse);
            CharacterController(keyboard);
        }

        private static void CharacterController(KeyboardState keyboard)
        {
            if (keyboard.IsKeyDown(Keys.W) || keyboard.IsKeyDown(Keys.Up))
            {
                Actors.Character.MoveUp();
            }

            if (keyboard.IsKeyDown(Keys.S) || keyboard.IsKeyDown(Keys.Down))
            {
                Actors.Character.MoveDown();
            }

            if (keyboard.IsKeyDown(Keys.A) || keyboard.IsKeyDown(Keys.Left))
            {
                Actors.Character.MoveLeft();
            }

            if (keyboard.IsKeyDown(Keys.D) || keyboard.IsKeyDown(Keys.Right))
            {
                Actors.Character.MoveRight();
            }

            if (keyboard.IsKeyDown(Keys.LeftShift))
            {
                Actors.Character.speedMultiplayer = 0.3f;
            }

            if (keyboard.IsKeyUp(Keys.LeftShift))
            {
                Actors.Character.speedMultiplayer = 1f;
            }
        }

        private static void MouseController(MouseState mouse)
        {
            if (mouse.LeftButton == ButtonState.Pressed)
            {
                if (framesPassed > 0)
                {
                    IsLeftMouseButtonHeld = true;
                }
                else
                {
                    framesPassed += 1;
                }

                if (GameState.GetGameState() == GameState.States.Gameplay)
                {
                    Actors.Character.Shoot();
                }
            }
            else
            {
                framesPassed = 0;
                IsLeftMouseButtonHeld = false;
            }
        }

        public static Vector2 GetMousePosition()
        {
            Vector2 mousePosition = Vector2.Zero;

            mousePosition = Mouse.GetState().Position.ToVector2();

            return mousePosition;
        }
    }
}