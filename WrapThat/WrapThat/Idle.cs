using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class Idle : IStrategy
    {
        private Animator animator;
        private float speed = 200;
        private Transform transform;
        public Idle(Animator animator, Transform transform)
        {
            this.transform = transform;
            this.animator = animator;
        }
        public void Update(ref Direction direction)
        {
            Vector2 translation = Vector2.Zero;
            if (direction == Direction.Front)
            {
                translation += new Vector2(0, -1);
            }
            else if (direction == Direction.Back)
            {

                translation += new Vector2(0, 1);
            }
            else if (direction == Direction.Right)
            {

                translation += new Vector2(-1, 0);
            }
            else if (direction == Direction.Left)
            {

                translation += new Vector2(1, 0);
            }
            transform.Translate(translation * GameWorld.DeltaTime * speed);
        }
    }
}
