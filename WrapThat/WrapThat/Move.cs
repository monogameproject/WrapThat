﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class Move : IStrategy
    {
        private Animator animator;
        private Transform transform;
        private float speed = 200;
        public Move(Animator animator, Transform transform)
        {
            this.animator = animator;
            this.transform = transform;
        }

        public void Update(ref Direction direction)
        {
            KeyboardState keystate = Keyboard.GetState();
            Vector2 translation = Vector2.Zero;
            if (keystate.IsKeyDown(Keys.W))
            {
                direction = Direction.Back;
                translation += new Vector2(0, -1);
            }
            if (keystate.IsKeyDown(Keys.S))
            {
                direction = Direction.Front;
                translation += new Vector2(0, 1);
            }
            if (keystate.IsKeyDown(Keys.A))
            {
                direction = Direction.Left;
                translation += new Vector2(-1, 0);
            }
            if (keystate.IsKeyDown(Keys.D))
            {
                direction = Direction.Right;
                translation += new Vector2(1, 0);
            }
            transform.Translate(translation * GameWorld.DeltaTime * speed);
        }
    }
}
