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
        }
    }
}
