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
        private GameObject gameObject;
        private Animator animator;
        private float speed = 200;
        private Transform transform;
        public MoveBox(Animator animator, Transform transform, GameObject gameObject)
        {
            //this.direction = 
            this.gameObject = gameObject;
            this.animator = animator;
            this.transform = transform;
            //playerTransform = (Transform)gameObject.GetComponent("Transform");
            //playerPosition = playerTransform.Position;

        }

        public void Update(ref Direction direction)
        {
            Vector2 translation = Vector2.Zero;
            if (playerPosition.X > transform.Position.X)
            {
                translation += new Vector2(-1, 0);
            }
            if (playerPosition.X < transform.Position.X)
            {
                translation += new Vector2(1, 0);
            }
            if (playerPosition.Y > transform.Position.Y)
            {
                translation += new Vector2(0, -1);
            }
            if (playerPosition.Y < transform.Position.Y)
            {
                translation += new Vector2(0, 1);
            }
            transform.Translate(translation * GameWorld.DeltaTime * speed);
        }
    }
}
