﻿using System;
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
                   
                    if (go.GetComponent("Door") != null)
                    {

                        Door localDoor = (Door)go.GetComponent("Door");
                        if (localDoor.Name == name)
                        {
                            GameWorld.Instance.RemoveGameObjects.Add(go);
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
