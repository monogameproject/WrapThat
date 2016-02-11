using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace WrapThat
{
    class PreassurePlate : Component, IUpdateable, ICollisionEnter, ICollisionExit
    {
        private bool pressed = false;
        private Color color;

        public PreassurePlate(GameObject gameObject, Color color) : base(gameObject)
        {
            SpriteRenderer spriteRenderer = (SpriteRenderer) gameObject.GetComponent("SpriteRenderer");
            spriteRenderer.Color = color;

        }

        public void Update()
        {

        }

        public void OnCollisionEnter(Collider other)
        {

            if (pressed == false)
            {
                pressed = true;
            }
            if (pressed == true)
            {
                pressed = false;
            }
        }

        public void OnCollisionExit(Collider other)
        {

        }
    }
}
