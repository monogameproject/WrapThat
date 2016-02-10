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
        private Vector2 playerPosition;
        private IStrategy strategy;
        private Transform transform;
        private Transform playerTransform;
        private Animator animator;
        public MoveableBox(GameObject gameObject) : base (gameObject)
        {
            animator = (Animator)GameObject.GetComponent("Animator");
            transform = gameObject.Transform;
            playerTransform = (Transform)GameObject.GetComponent("Transform");
            playerPosition = playerTransform.Position;
        }
        public void Update()
        {
        }

        public void OnCollisionEnter(Collider other)
        {
            
            if (other is Player)
            {

            }
        }

        public void OnCollisionExit(Collider other)
        {
            throw new NotImplementedException();
        }
    }
}
