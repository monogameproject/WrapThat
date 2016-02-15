using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class MoveBox : IStrategy
    {
        private Animator animator;
        private float speed = 200;
        private Transform transform;
        public MoveBox(Animator animator, Transform transform)
        {
            this.animator = animator;
            this.transform = transform;
        }

        public void Update(ref Direction direction)
        {
            Vector2 translation = Vector2.Zero;
            if (direction == Direction.Front)
            {
                translation += new Vector2(0, 1);
            }
            if (direction == Direction.Back)
            {
                translation += new Vector2(0, -1);
            }
            if (direction == Direction.Right)
            {
                translation += new Vector2(1, 0);
            }
            if (direction == Direction.Left)
            {
                translation += new Vector2(-1, 0);
            }
            transform.Translate(translation * GameWorld.DeltaTime * speed);
        }
    }
}
