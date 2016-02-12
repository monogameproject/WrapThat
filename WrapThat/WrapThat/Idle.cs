using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class Idle : IStrategy
    {
        private Animator animator;
        public Idle(Animator animator)
        {
            this.animator = animator;
        }
        public void Update(ref Direction direction)
        {
            if (direction == Direction.Front)
            {
                direction = Direction.Back;
            }
            else if (direction == Direction.Back)
            {
                direction = Direction.Front;
            }
            else if (direction == Direction.Right)
            {
                direction = Direction.Left;
            }
            else if (direction == Direction.Left)
            {
                direction = Direction.Right;
            }
        }
    }
}
