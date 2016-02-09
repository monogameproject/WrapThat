﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace WrapThat
{
    class PreassurePlateBuilder : IBuilder
    {
        private GameObject gameObject;
        public void BuildGameObject(Vector2 position)
        {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent(new SpriteRenderer(gameObject, "PreassurePlate", 2f));
            gameObject.Transform.Position = new Vector2(200, 10);
            gameObject.AddComponent(new PreassurePlate());
            this.gameObject = gameObject;


        }

        public GameObject GetResult()
        {
            return gameObject;
        }
    }
}