using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class BoxPreassurePlate : Component, IUpdateable
    {
        private bool pressed = false;
        private Color color;
        public BoxPreassurePlate(GameObject gameObject, Color color) : base (gameObject)
        {
            SpriteRenderer spriteRenderer = (SpriteRenderer)gameObject.GetComponent("SpriteRenderer");
            spriteRenderer.Color = color;

        }

        public void Update()
        {

        }
    }
}
