using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class MoveableBox : Component, IUpdateable, ICollisionEnter, ICollisionExit
    {
        Direction playerDirection;
        private IStrategy strategy;
        private Direction direction;
        private Transform transform;
        private Animator animator;
        public Player player;
        public Vector2 translation = Vector2.Zero;
        public MoveableBox(GameObject gameObject) : base(gameObject)
        {

            transform = gameObject.Transform;
            animator = (Animator)GameObject.GetComponent("Animator");

        }
        public void Update()
        {

        }
        public void Update(Direction direction)
        {
            strategy = new Idle(animator, transform);
        }

        public void OnCollisionEnter(Collider other)
        {
            if (other.GameObject.GetComponent("Player") == null && other.GameObject.GetComponent("Gift") == null && other.GameObject.GetComponent("BoxPreassurePlate") == null)
            {

                strategy = new Idle(animator, transform);
                strategy.Update(ref playerDirection);
                player.OnCollisionEnter(other);
            }
            else if (other.GameObject.GetComponent("Player") != null)
            {
                player = (Player)other.GameObject.GetComponent("Player");
                playerDirection = player.Direction;
                strategy = new MoveBox(animator, transform);
                strategy.Update(ref playerDirection);
                
            }

        }

        public void OnCollisionExit(Collider other)
        {
            strategy = new Idle(animator, transform);
        }
    }
}
