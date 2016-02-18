using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class DoorBuilder : IBuilder
    {
        private GameObject gameObject;
        private string name;
        public void BuildGameObject(Vector2 position)
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "DoorOne", 1f));
            gameObject.Transform.Position = new Vector2(410, 150);
            gameObject.AddComponent(new Door(gameObject, name));
            gameObject.AddComponent(new Collider(gameObject));
            this.gameObject = gameObject;
        }

        public void BuildGameObject(Vector2 position, string name)
        {
            this.name = name;
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "DoorOne", 0.1f));
            gameObject.Transform.Position = position;
            gameObject.AddComponent(new Door(gameObject, name));
            gameObject.AddComponent(new Collider(gameObject));
            this.gameObject = gameObject;
        }

        public GameObject GetResult()
        {
            return gameObject;
        }
    }
}
