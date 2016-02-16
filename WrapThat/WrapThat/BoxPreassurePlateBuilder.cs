﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WrapThat
{
    class BoxPreassurePlateBuilder : IBuilder
    {
        private GameObject gameObject;
        private string name;
        public void BuildGameObject(Vector2 position)
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "BoxPreassurePlate", 1f));
            gameObject.Transform.Position = new Vector2(410, 150);
            gameObject.AddComponent(new BoxPreassurePlate(gameObject, Color.White, name));
            gameObject.AddComponent(new Collider(gameObject));
            this.gameObject = gameObject;
        }
        public void BuildGameObject(Vector2 position, string name)
        {
            this.name = name;
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "BoxPreassurePlate", 1f));
            gameObject.Transform.Position = new Vector2(410, 150);
            gameObject.AddComponent(new BoxPreassurePlate(gameObject, Color.White, name));
            gameObject.AddComponent(new Collider(gameObject));
            this.gameObject = gameObject;
        }
        public GameObject GetResult()
        {
            return gameObject;
        }
    }
}
