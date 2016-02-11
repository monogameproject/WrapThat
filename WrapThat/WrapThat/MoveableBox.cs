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
        private int speed = 200;
        private IStrategy strategy;
        private Transform transform;
        private Animator animator;
        public Vector2 translation = Vector2.Zero;
        private Vector2 currentDirection;
        public MoveableBox(GameObject gameObject) : base (gameObject)
        {
            transform = gameObject.Transform;
            currentDirection = new Vector2(0, 0);
            animator = (Animator)GameObject.GetComponent("Animator");
        }
        public void Update()
        {
            strategy = new MoveBox(animator, transform);



        }

        public void OnCollisionEnter(Collider other)
        {
        }

        public void OnCollisionExit(Collider other)
        {
        }
    }
}
