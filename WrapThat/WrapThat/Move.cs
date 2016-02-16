using Microsoft.Xna.Framework;
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
            Vector2 translation = Vector2.Zero;
            if (direction == Direction.Back)
            {
                translation += new Vector2(0, -1);
            }
            if (direction == Direction.Front)
            {
                translation += new Vector2(0, 1);
            }
            if (direction == Direction.Left)
            {
                translation += new Vector2(-1, 0);
            }
            if (direction == Direction.Right)
            {
                translation += new Vector2(1, 0);
            }
            animator.PlayAnimation("Idle" + direction);
            transform.Translate(translation * GameWorld.DeltaTime * speed);
        }
    }
}
