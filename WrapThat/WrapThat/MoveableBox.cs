using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class MoveableBox : Component, IUpdateable
    {
        Direction direction = Direction.Front;
        private IStrategy strategy;
        private Transform transform;
        private Animator animator;
        public MoveableBox(GameObject gameObject) : base (gameObject)
        {
            animator = (Animator)GameObject.GetComponent("Animator");
            transform = gameObject.Transform;
        }
        public void Update()
        {
            strategy = new MoveBox(animator, transform);
            strategy.Update(ref direction);

        }
    }
}
