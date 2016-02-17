using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WrapThat
{
    class Gift :  Component,IBuilder, ICollisionEnter, ICollisionExit
    {
        private GameObject gameObject;
        private PreassurePlate preassurePlate;
        public GameObject GetResult()
        {
           return gameObject;
        }

        public void BuildGameObject(Vector2 position)
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "Gave", 1f));
            gameObject.Transform.Position = new Vector2(700,400);
            gameObject.AddComponent(new Collider(gameObject));
            gameObject.AddComponent(new Gift());
            this.gameObject = gameObject;

        }

        public void OnCollisionEnter(Collider other)
        {
            if(other.GameObject.GetComponent("Player") != null)
            {
                if (GameWorld.Instance.Level == "level 1")
                {

                    GameWorld.Instance.Completed = true;
                    GameWorld.Instance.Level = "level 2";
                }
            }
        }

        public void OnCollisionExit(Collider other)
        {
           // Debug.Write("exit gift/level");
        }

        public void BuildGameObject(Vector2 position, string name)
        {
            throw new NotImplementedException();
        }
    }
}
