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
        private Color color;
        private string name;

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

                int j = GameWorld.GameObjects.Count;
                for (int i = 0; i < j; i++)
                {
                    GameObject go = GameWorld.GameObjects[i];
                    //GameObject go = new GameObject();
                    if (go.GetComponent("DoorOne") != null)
                    {
                        //Colliders.Remove((Collider)go.GetComponent("Collider"));
                        GameWorld.GameObjects.Remove(GameWorld.GameObjects[i]);
                    }
                }
                //removeGameObjects.Add(GameObjects[0]);
                //    foreach (GameObject go in GameWorld.GameObjects)
                //{

                        
                //    if (go.GetComponent("DoorOne") != null)
                //    {
                //        DoorOne localDoor = (DoorOne)go.GetComponent("DoorOne");
                //        if (localDoor.Name == name)
                //        {
                          
                //        }
                    
                //    }
                //}
              

            }
            
        }

        public void OnCollisionExit(Collider other)
        {

        }
    }
}
