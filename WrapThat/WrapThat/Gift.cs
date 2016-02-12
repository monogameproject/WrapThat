using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WrapThat
{
    class Gift : IBuilder, ICollisionEnter, ICollisionExit
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
            this.gameObject = gameObject;

        }

        public void OnCollisionEnter(Collider other)
        {
            if (GameWorld.Instance.Level=="level 1")
            {

                GameWorld.Instance.Completed = true;
            }
            
        }

        public void OnCollisionExit(Collider other)
        {
            throw new NotImplementedException();
        }
    }
}
