using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class MoveBox : IStrategy
    {
        private Transform playerTransform;
        private Vector2 playerPosition;
        private Direction direction;
        private Animator animator;
        private float speed = 200;
        private Transform transform;
        private GameObject gameObject;
        public MoveBox(Animator animator, Transform transform)
        {
            direction = Direction.Front;
            this.animator = animator;
            this.transform = transform;
            //playerTransform = (Transform)gameObject.GetComponent("Transfom");
            //playerPosition = playerTransform.Position;
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
            //if (playerPosition.X > transform.Position.X)
            //{
            //    translation += new Vector2(-1, 0);
            //    direction = Direction.Left;
            //}
            //if (playerPosition.X < transform.Position.X)
            //{
            //    translation += new Vector2(1, 0);
            //    direction = Direction.Right;
            //}
            //if (playerPosition.Y > transform.Position.Y)
            //{
            //    translation += new Vector2(0, -1);
            //    direction = Direction.Back;
            //}
            //if (playerPosition.Y < transform.Position.Y)
            //{
            //    translation += new Vector2(0, 1);
            //    direction = Direction.Front;
            //}
            transform.Translate(translation * GameWorld.DeltaTime * speed);
            
        }
    }
}
