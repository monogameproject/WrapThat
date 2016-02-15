using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class BoxPreassurePlate : Component, IUpdateable, ICollisionEnter, ICollisionExit
    {
        private bool boxPressed = false;
        private Color color;
        private GameObject doorTwo;

        public bool BoxPressed
        {
            get
            {
                return boxPressed;
            }
        }

        public BoxPreassurePlate(GameObject gameObject, Color color) : base (gameObject)
        {
            foreach  (GameObject door in GameWorld.GameObjects)
            {
                if (door.GetComponent("DoorTwo") != null)
                {
                    doorTwo = door;
                }
            }
            SpriteRenderer spriteRenderer = (SpriteRenderer)gameObject.GetComponent("SpriteRenderer");
            spriteRenderer.Color = color;
        }

        public void Update()
        {

        }

        public void OnCollisionEnter(Collider other)
        {
            if (other.GameObject.GetComponent("MoveableBox") != null)
            {
                SpriteRenderer spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
                color = Color.Red;
                spriteRenderer.Color = color;
                boxPressed = true;
            }
        }

        public void OnCollisionExit(Collider other)
        {
            if (other.GameObject.GetComponent("MoveableBox") != null)
            {
                SpriteRenderer spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
                color = Color.Red;
                spriteRenderer.Color = color;
                boxPressed = false;
            }
        }
    }
}
