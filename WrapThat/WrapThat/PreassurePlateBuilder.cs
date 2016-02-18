using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WrapThat
{
    class PreassurePlateBuilder : IBuilder
    {
        private GameObject gameObject;
        private string name;
        public void BuildGameObject(Vector2 position)
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "PreassurePlate", 0.1f));
            gameObject.Transform.Position = new Vector2(180, 230);
            gameObject.AddComponent(new PreassurePlate(gameObject, Color.White, name));
            gameObject.AddComponent( new Collider(gameObject));
            this.gameObject = gameObject;


        }

        public void BuildGameObject(Vector2 position, string name)
        {
            this.name = name;
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "PreassurePlate", 0.1f));
            gameObject.Transform.Position = new Vector2(50, 350);
            gameObject.AddComponent(new PreassurePlate(gameObject, Color.White, name));
            gameObject.AddComponent(new Collider(gameObject));
            this.gameObject = gameObject;
        }

        public void BuildGameObject(Vector2 position, string name, string spriteName)
        {
            throw new NotImplementedException();
        }

        public GameObject GetResult()
        {
            return gameObject;
        }
    }
}
