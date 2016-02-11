using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class MoveableBox : Component, IUpdateable, ICollisionEnter, ICollisionExit
    {
        Direction direction = Direction.Front;
        private IStrategy strategy;
        private Transform transform;
        private Animator animator;
        public Vector2 translation = Vector2.Zero;
        public MoveableBox(GameObject gameObject) : base (gameObject)
        {
            transform = gameObject.Transform;
            animator = (Animator)GameObject.GetComponent("Animator");

        }
        public void Update()
        {
            strategy = new Idle(animator);
            strategy.Update(ref direction);

        }

        public void OnCollisionEnter(Collider other)
        {
            strategy = new MoveBox(animator, transform);
        }

        public void OnCollisionExit(Collider other)
        {
            strategy = new Idle(animator);
        }
    }
}
