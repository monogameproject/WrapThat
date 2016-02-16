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
        private string name;
        public bool PlayerPressed
        {
            get
            {
                return playerPressed;
            }
        }

        public PreassurePlate(GameObject gameObject, Color color, string name) : base(gameObject)
        {
            this.name = name;
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
                foreach (GameObject door in GameWorld.GameObjects)
                {
                    
                    if (door.GetComponent("DoorOne") != null)
                    {
                        DoorOne localDoor = (DoorOne)door.GetComponent("DoorOne");
                        if(localDoor.Name == name)
                        {

                            GameWorld.GameObjects.Remove(door);
                        }
                    }
                }
               
            }
            
        }

        public void OnCollisionExit(Collider other)
        {

        }
    }
}
