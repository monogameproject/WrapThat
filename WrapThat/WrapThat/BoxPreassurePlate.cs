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
        public BoxPreassurePlate(GameObject gameObject, Color color) : base (gameObject)
        {
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
                color = Color.Red;
                boxPressed = true;
            }
        }

        public void OnCollisionExit(Collider other)
        {
            if (other.GameObject.GetComponent("MoveableBox") != null)
            {
                color = Color.White;
                boxPressed = false;
            }
        }
    }
}
