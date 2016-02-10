using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WrapThat
{
    class BoxPreassurePlateBuilder : IBuilder
    {
        private GameObject gameObject;
        public void BuildGameObject(Vector2 position)
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "BoxPreassurePlate", 1f));
            gameObject.Transform.Position = new Vector2(10, 10);
            gameObject.AddComponent(new Animator(gameObject));
            gameObject.AddComponent(new BoxPreassurePlate(gameObject, Color.White));
        }

        public GameObject GetResult()
        {
            return gameObject;
        }
    }
}
