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
        private bool playerPressed = false;
        private Color color;

        public bool PlayerPressed
        {
            get
            {
                return playerPressed;
            }
        }

        public PreassurePlate(GameObject gameObject, Color color) : base(gameObject)
        {
            this.color = color;
        }

        public void Update()
        {

        }

        public void OnCollisionEnter(Collider other)
        {
            if (other.GameObject.GetComponent("Player") != null)
            {
                SpriteRenderer spriteRenderer = (SpriteRenderer)GameObject.GetComponent("SpriteRenderer");
                color = Color.Red;
                spriteRenderer.Color = color;
                playerPressed = true;
            }
            
        }

        public void OnCollisionExit(Collider other)
        {

        }
    }
}
