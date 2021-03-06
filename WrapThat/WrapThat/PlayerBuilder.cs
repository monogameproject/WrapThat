﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WrapThat
{
    class PlayerBuilder : IBuilder
    {
        private GameObject gameObject;
        public void BuildGameObject(Vector2 position)
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "PlayerSheet", 1f));
            gameObject.Transform.Position = new Vector2(50, 50);
            gameObject.AddComponent(new Animator(gameObject));
            gameObject.AddComponent(new Player(gameObject));
            gameObject.AddComponent(new Collider(gameObject));

            this.gameObject = gameObject;

        }

        public void BuildGameObject(Vector2 position, string name)
        {
            throw new NotImplementedException();
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
